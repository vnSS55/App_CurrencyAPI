using APPCurrency_API.Services;

namespace App_CurrencyAPI
{
    public partial class Form1 : Form
    {
        // Swap button var

        bool swap_indicator = false; // Bool indicator to swap 
        API_response_currency last_result_api; // variable to save requests to save the last request

        // global var
        private readonly API_services api_service = new API_services(); // The api service object to execute the methods

        private async void Currency_data_add() // function to store all the currencyes in the selection bar
        {
            API_services api_service = new API_services(); // public variable to all the forms, when initialized make a request to get all the avaliable currencys

            var data = await api_service.Currency_Data(); // store all the currencyes in data

            // combobox configuration
            Base_currency_combobox.Items.Add("Select"); // pre select "Select" for a default option
            Target_currency_combobox.Items.Add("Select");

            Base_currency_combobox.SelectedIndex = 0; // start at "Select"
            Target_currency_combobox.SelectedIndex = 0;

            Base_currency_combobox.Text = Base_currency_combobox.SelectedIndex.ToString(); // Defines the text 
            Target_currency_combobox.Text = Target_currency_combobox.SelectedIndex.ToString();

            foreach (var item in data.supported_codes) // Add all possible coins to the combobox for the user
            {
                Base_currency_combobox.Items.Add(item[0]);
                Target_currency_combobox.Items.Add(item[0]);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Currency_data_add();
        }
        // Button Function
        private async void Get_currency_button_Click(object sender, EventArgs e)
        {
            string base_value = Base_currency_combobox.Text; // Get the first currency
            string target_value = Target_currency_combobox.Text; // Second currency

            if (base_value == "Select" || target_value == "Select") // Error message
            {
                info_label.Text = "ERROR - Select the Currency";
                return;
            }
            else // Core code
            {
                double value; // get the value inserted 
                bool sucess = double.TryParse(Value_TextBox.Text, out value); // confirm if the value inserted is a number

                if (sucess) // Get the response and show the data
                {
                    var result_api = await api_service.Currency_Conversion(base_value, target_value, value); // resquest the data with the class object already converted on the class
                    last_result_api = result_api; // store the result of the api for later uses like swap
                    double result_convertion = Convert.ToDouble((result_api.conversion_result)); //Convertion to double 
                    Result_Textbox.Text = Math.Round(result_convertion, 2).ToString(); // Show the result
                    info_label.Text = $"Convertion Rate: {Math.Round(result_api.conversion_rate, 2)}\n1 ->{Math.Round(1 * result_api.conversion_rate, 2)}"; // info on the UI
                    swap_indicator = false;
                }
                else // Error message
                {
                    info_label.Text = "ERRO - Insert numbers";
                    return;
                }

            }
        }
        private void Swap_currency_button_Click(object sender, EventArgs e)
        {
            Swap_currency();
        }
        private async void Swap_currency()
        {
            // vars
            string base_currency;
            string target_currency;
            double amount;
            double swap_amount;
            bool a_bool;


            base_currency = Base_currency_combobox.Text; // Get the currencies to swap
            target_currency = Target_currency_combobox.Text;

            a_bool = double.TryParse(Value_TextBox.Text, out amount); // Check if valid

            if (!swap_indicator)
            {
                if (last_result_api != null && a_bool)
                {
                    // if the currencies are the same, and the number is also valid
                    if (last_result_api.base_code == base_currency && last_result_api.target_code == target_currency)
                    {
                        swap_amount = amount / last_result_api.conversion_rate; // convert the amount to the other currency

                        Base_currency_combobox.Text = target_currency; // Swap the currencies
                        Target_currency_combobox.Text = base_currency;

                        // UI
                        Result_Textbox.Text = Math.Round(swap_amount, 2).ToString();
                        info_label.Text = $"Convertion Rate: {Math.Round(1 / last_result_api.conversion_rate, 2)}\n1 ->{Math.Round(1 / last_result_api.conversion_rate, 2)}";
                    }
                    else
                    {
                        // if not just change the currencies
                        // Swap
                        Base_currency_combobox.Text = target_currency; // Swap the currencies
                        Target_currency_combobox.Text = base_currency;

                        info_label.Text = "Info...";
                    }
                }
                else
                {
                    // Swap
                    Base_currency_combobox.Text = target_currency; // Swap the currencies
                    Target_currency_combobox.Text = base_currency;

                    info_label.Text = "Info...";
                }
                swap_indicator = true;
            }

            // if the swap was already made
            // return to the normal values
            // or just swap the currencies back
            else
            {
                if (last_result_api != null && a_bool)
                {
                    swap_amount = last_result_api.conversion_result;

                    // UI
                    Base_currency_combobox.Text = last_result_api.base_code;
                    Target_currency_combobox.Text = last_result_api.target_code;

                    Result_Textbox.Text = Math.Round(swap_amount, 2).ToString();
                    info_label.Text = $"Convertion Rate: {Math.Round(last_result_api.conversion_rate, 2)}\n1 ->{Math.Round(last_result_api.conversion_rate, 2)}";
                }
                else
                {
                    // Swap
                    Base_currency_combobox.Text = target_currency; // Swap the currencies
                    Target_currency_combobox.Text = base_currency;

                    info_label.Text = "Info...";
                }
                swap_indicator = false;
            }
        }
    }
}
