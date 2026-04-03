using APPCurrency_API.Services;

namespace App_CurrencyAPI
{
    public partial class Form1 : Form
    {

        // The api service object to exe the methods
        private readonly API_services api_service = new API_services();

        // last api to save requests
        API_response_currency last_result_api;
        // last sucess to confirm that the currency is the same, avoiding error's 
        bool last_sucess;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            API_services api_service = new API_services();

            var data = await api_service.Currency_Data();

            // combobox configuration

            // pre select "Select" for a default option
            Base_currency_combobox.Items.Add("Select");
            Target_currency_combobox.Items.Add("Select");
            Base_currency_combobox.SelectedIndex = 0;
            Target_currency_combobox.SelectedIndex = 0;

            // Add all possible coins to the combobox for the user
            foreach (var item in data.supported_codes)
            {
                Base_currency_combobox.Items.Add(item[0]);
                Target_currency_combobox.Items.Add(item[0]);
            }

        }

        private async void Get_currency_button_Click(object sender, EventArgs e)
        {
            // Gets the currency to convert
            string base_value = Base_currency_combobox.Text;
            string target_value = Target_currency_combobox.Text;

            if (base_value=="Select"|| target_value =="Select")
            {
                info_label.Text = "ERROR - Select the Currency";
                return;
            }
            else
            {
                // Recieving the double value and error message
                double value;
                bool sucess = double.TryParse(Value_TextBox.Text, out value);
                last_sucess = sucess;
                if (sucess)
                {
                    // resquest the data with the class object already converted on the class 
                    var result_api = await api_service.Currency_Conversion(base_value, target_value, value);
                    // store the result of the api for later uses like swap
                    last_result_api = result_api;
                    //Convertion to double 
                    double result_convertion = Convert.ToDouble((result_api.conversion_result));
                    // Show the result
                    Result_Textbox.Text = Math.Round(result_convertion).ToString();
                    // info on the UI
                    info_label.Text = $"\nConvertion Rate: {result_api.conversion_rate}\n1 ->{1 * result_api.conversion_rate}";
                }
                // Error message
                else
                {
                    info_label.Text = "ERRO - Insert numbers";
                    return;
                }
            }
        }
        // swap the currencyes, avoid the use of another request to the Http client
        private void Swap_currency_button_Click(object sender, EventArgs e)
        {
            if (api_service == null && last_sucess == false && last_result_api == null)
            {
                if (last_sucess == false)
                {
                    info_label.Text = "ERROR - Only insert numbers";
                }
                else if (api_service == null)
                {
                    info_label.Text = "ERROR - Select a currency";
                }
                else
                {
                    info_label.Text = "ERROR - Select a currency and a value";
                }
                return;
            }
            else
            {
                // Gets the currency to convert
                string base_value = Base_currency_combobox.Text;
                string target_value = Target_currency_combobox.Text;

                // swap the currencyes
                Base_currency_combobox.Text = target_value;
                Target_currency_combobox.Text = base_value;

                // swap convertion rate
                double convertion_rate = 1 / last_result_api.conversion_rate;

                // Recieving the double
                double value = Convert.ToDouble(Value_TextBox.Text);

                double result_convertion = value * convertion_rate;

                Result_Textbox.Text = Math.Round(result_convertion).ToString();

                info_label.Text = $"Convertion Rate: {convertion_rate}\n1 ->{1 * convertion_rate}";

            }
        }
    }
}
