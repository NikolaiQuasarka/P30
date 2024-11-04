namespace P30
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       
        public static object SqlConnData()
        {
            DBConnetcionForm form = new DBConnetcionForm();
            string hostName = "";
            string login = "";
            string password = "";

            form.FormClosing += (sender, e) =>
            {
                hostName = form.HostName;
                login = form.Login;
                password = form.Password;
            };

            Application.Run(form);

            return new { HostName = hostName, Login = login, Password = password };
        }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();


            object dbConnData = SqlConnData();
            Application.Run(new Main());
        }
    }
}