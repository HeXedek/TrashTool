using System.Text;
using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Numerics;
using System.Linq;
using System.Linq.Expressions;

try
{

    string Webhook_link = "https://discord.com/api/webhooks/1101435685245825074/x28YmiBLrqstPXCut4_o1ZgIB5AGRSXu4LecsEXlx1Ere5usNoRX9ZGIOQRLRfVq_B0s";

    using (dWebHook dcWeb = new dWebHook())
    {
        dcWeb.UserName = "Trastool log";
        dcWeb.WebHook = Webhook_link;
        dcWeb.SendMessage("Trashtool Has been run");
    }

    string delay;
    int sex;

    if (File.Exists("log.log"))
    {
        File.Delete("log.log");
        // Made by HeXED#1753
        // https://discord.gg/h2eHCC5KmP
        // Join ben server!
    }

    if (File.Exists("versioninfo.tt"))
    {
        File.Delete("verioninfo.tt");
    }

    log("Log Start OS INFO: " + Environment.OSVersion);

    if(!Directory.Exists("data"))
    {
        Directory.CreateDirectory("data");
    }
    using (FileStream fileStream = File.Create("data\\versioninfo.tt"))
    {
        byte[] bytes = new UTF8Encoding(true).GetBytes("0.0.3");
        fileStream.Write(bytes, 0, bytes.Length);
    }

    Console.Write("Checking for updates");
    log("Checking Updates");
    string remoteUri = "https://github.com/HeXedek/TrashTool/releases/download/release/";
    string fileName = "versioninfo.tt", myStringWebResource = null;
    WebClient myWebClient = new WebClient();
    myStringWebResource = remoteUri + fileName;
    myWebClient.DownloadFile(myStringWebResource, fileName);

    string contents = File.ReadAllText("data\\versioninfo.tt");
    string contents2 = File.ReadAllText("versioninfo.tt");

    if (!contents.Equals(contents2))
    {
        log("Update found!");
        if (!File.Exists("Updater.exe"))
        {
            string remoteUri1 = "https://github.com/HeXedek/TrashTool/releases/download/release/";
            string fileName1 = "Updater.exe", myStringWebResource1 = null;
            WebClient myWebClient1 = new WebClient();
            myStringWebResource1 = remoteUri1 + fileName1;
            myWebClient1.DownloadFile(myStringWebResource1, fileName1);
            string strCmdText;
            strCmdText = "/C Updater.exe";
            Console.Clear();
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        else
        {
            string strCmdText;
            strCmdText = "/C Updater.exe";
            Console.Clear(); 
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        
    }
    else
    {
        Console.Clear();
        Console.SetWindowSize(120, 30);
    }

    Console.SetWindowSize(120, 30);
    log("Windows size set");
    Console.Clear();
    // Made by HeXED#1753
    Console.Write("                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ");
    Console.Write("                                            ▀█▀ █▀▄ █▀█ █▀▀ █ █ ▀█▀ █▀█ █▀█ █                                          \r\n                                             █  █▀▄ █▀█ ▀▀█ █▀█  █  █ █ █ █ █                                          \r\n                                             ▀  ▀ ▀ ▀ ▀ ▀▀▀ ▀ ▀  ▀  ▀▀▀ ▀▀▀ ▀▀▀                                        ");
    Console.Write("                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ");
    System.Threading.Thread.Sleep(3000);
    log("Checking if user agreed.");
    if (File.Exists("data\\agree.tt"))
    {
        bool flag2 = File.ReadAllText("data\\agree.tt").Contains("True");
        if (flag2)
        {
            log("User agreed");
            Trashtool();
        }
        else
        {
            log("User didn't agreed");
            akceptacja();
        }
    }
    else
    {
        log("User didn't agreed");
        akceptacja();
    }



    void akceptacja()
    {
        Console.SetWindowSize(120, 30);
        log("Windows size set");
        Console.Clear();
        // Made by HeXED#1753
        log("Console Cleared");
        Console.WriteLine("To use this program you need accept the rules of this program                                                           ");
        Console.WriteLine("Press any key to read rules...");
        Console.WriteLine("");
        Console.Write("[>]"); Console.ReadKey();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        log("Showing rules");
        Rules();


    }

    void Rules()
    {
        string agree;
        Console.Clear();
        // Made by HeXED#1753
        Console.WriteLine("                                                        TrashTool");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("You accept that we will collect data about your os and only this program logs");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("We are not responsible for anything that was did using this program");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This program is made for educational purposes");
        Console.WriteLine("type 'agree' to agree to rules");
        Console.WriteLine("");
        Console.Write("[>]");
        agree = Console.ReadLine();
        if (agree == "agree")
        {
            Console.Clear();
            log("User agreed to rules");
            using (FileStream fileStream = File.Create("data\\agree.tt"))
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes("True");
                fileStream.Write(bytes, 0, bytes.Length);
                log("Created agree file");
            }
            Trashtool();

        }
        else
        {
            log("rules: not agreed");
            Rules();
        }



    }

    void Trashtool()
    {
        Console.SetWindowSize(120, 30);
        string selection;
        Console.Clear();
        Console.Write("                                            ▀█▀ █▀▄ █▀█ █▀▀ █ █ ▀█▀ █▀█ █▀█ █  \r\n                                             █  █▀▄ █▀█ ▀▀█ █▀█  █  █ █ █ █ █  \r\n                                             ▀  ▀ ▀ ▀ ▀ ▀▀▀ ▀ ▀  ▀  ▀▀▀ ▀▀▀ ▀▀▀");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("                                           Discord Tools            ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Other Tools");
        Console.WriteLine("");
   //   Console.WriteLine("                                           Discord Tools            Other Tools")
        Console.WriteLine("                                        1) Webhook Tools");
        log("Trashtool Started");
        Console.WriteLine("");
        Console.Write("[>]");
        selection = Console.ReadLine();
        if (selection == "1")
        {
            webhooksender();
        }
        else
        {
            Trashtool();
        }
    }

    void webhooksender()
    {
        string wurl;
        string response;
        log("webhook sender started");
        Console.Clear();
        Console.Write("Welcome To");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" Discord Webhook");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" Tools"); 
        log("Started Webhook Tools");
        Console.WriteLine(" Enter Discord Webhook url: ");
        Console.WriteLine("");
        Console.Write("[>]");
        log("Webhook is set");
        wurl = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("1) Send normal Message");
        Console.WriteLine("2) Send File");
        Console.WriteLine("3) Webhook Spammer");
        Console.WriteLine("");
        Console.Write("[>]");
        response = Console.ReadLine();
        if (response == "1")
        {
            Normal();
        }
        else
        {
            if (response == "2")
            {
                filesender();
            }
            else
            {
                if (response == "3")
                {
                    webhookspammer();
                }
                else
                {
                    webhooksender();
                }
            }

        }
        void Normal()
        {
            string message;
            string username;
            string yn;  
            log("Webhook: Using normal mode");
            Console.Clear();
            Console.WriteLine("What username your webhook should have?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            username = Console.ReadLine();
            log("Webhook: Username set");
            Console.Clear();
            Console.WriteLine("What message you want to send?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            message = Console.ReadLine();
            log("Message set");
            Console.Clear();
            Console.WriteLine("Your webhook name is: " + username + " and message is: " + message + " Do you wish to send?");
            Console.WriteLine("");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            Console.WriteLine("Quit");
            Console.WriteLine("");
            Console.Write("[>]");
            yn = Console.ReadLine();
            if (yn == "yes" || yn == "Yes" || yn == "y")
            {
                using (dWebHook dcWeb = new dWebHook())
                {
                    dcWeb.UserName = username;
                    dcWeb.WebHook = wurl;
                    dcWeb.SendMessage(message);
                    Console.Clear();
                    Console.WriteLine("Message has been send");
                    log("Webhook Message sent");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    System.Threading.Thread.Sleep(3000);
                    Trashtool();
                }

            }
            else
            {
                if (yn == "No" || yn == "no" || yn == "n")
                {
                    Normal();
                }
                else
                {
                    webhooksender();
                }
            }




        }

        void filesender()
        {
            string filePath;
            log("Started file sender webhook");
            Console.Clear();
            Console.WriteLine("Paste in your file location");
            Console.WriteLine("");
            Console.Write("[>]");
            filePath = Console.ReadLine();
            log("FilePath set");
            Console.Clear();
            Console.WriteLine("You are sending this file: " + filePath + " Do you wish to send?");
            Console.WriteLine("");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            Console.WriteLine("Quit");
            Console.WriteLine("");
            Console.Write("[>]");
            string wish = Console.ReadLine();
            if (wish == "yes" || wish == "Yes" || wish == "y")
            {
                log("Sending file.");
                HttpClient client = new HttpClient();
                MultipartFormDataContent content = new MultipartFormDataContent();
                var file = File.ReadAllBytes(filePath);
                content.Add(new ByteArrayContent(file, 0, file.Length), Path.GetExtension(filePath), filePath);
                client.PostAsync(wurl, content).Wait();
                client.Dispose();
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Sent!");
                log("Sent!");
                System.Threading.Thread.Sleep(3500);
                Console.Clear();
                System.Threading.Thread.Sleep(1500);
                Trashtool();
            }
            else
            {
                if (wish == "No" || wish == "no" || wish == "n")
                {
                    filesender();
                    log("Restarted filesender");
                }
                else
                {
                    webhooksender();
                    log("Quit.");
                }
            }



        }

        void webhookspammer()
        {
            string message1;
            string spamname;
            string ynt;
            log("Webhook: Using spam mode");
            Console.Clear();
            Console.WriteLine("What message you want to send?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            message1 = Console.ReadLine();
            log("Message set");
            Console.Clear();
            Console.WriteLine("What delay you want to set?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            delay = Console.ReadLine();
            log("Delay Set");
            bool onlynumbers = delay.All(char.IsDigit);
            if(onlynumbers == false)
            {
                delay = String.Empty;
                webhookspammer();
            }
            Console.Clear();
            Console.WriteLine("Your Webhook message is: " + message1 + " Do you wish to spam?");
            Console.WriteLine("");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            Console.WriteLine("Quit");
            Console.WriteLine("");
            sex = int.Parse(delay);
            Console.Write("[>]");
            ynt = Console.ReadLine();
            if (ynt == "yes" || ynt == "Yes" || ynt == "y")
            {
                log("Spamming");
                Console.WriteLine(sex);
                WebClient client = new WebClient();
                int msgnmb = 0;
                Console.Clear();
                Console.WriteLine("Spamming");
                Console.WriteLine("Hold any key to stop");
                while (!Console.KeyAvailable)
                {
                    yourmum();
                    void yourmum()
                    {
                        msgnmb++;
                        Console.Clear();
                        Console.WriteLine("Spamming Message:" + msgnmb);
                        Console.WriteLine("Hold any key to stop");
                        try
                        {
                            client.Headers.Add("Content-Type", "application/json");
                            string payload = "{\"content\": \"" + message1 + "\"}";
                            Console.ForegroundColor = ConsoleColor.White;
                            client.UploadData(wurl, Encoding.UTF8.GetBytes(payload));
                            System.Threading.Thread.Sleep(sex);
                        }
                        catch
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("X | One message has been not send because of limit.");
                            Console.WriteLine("Retry in 5 seconds");
                            System.Threading.Thread.Sleep(5000);
                            yourmum();
                        }
                    }
                    
                    
                }
                log("Stopped");
                Trashtool();

            }
            else
            {
                if (ynt == "No" || ynt == "no" || ynt == "n")
                {
                    webhookspammer();
                    log("restarted spammer");
                }
                else
                {
                    Trashtool();
                    log("Quit.");
                }
            }

        }





    }

}
catch (Exception ex)
{
    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Error has been catched", Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Message: " + ex.Message, Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Stack Trace: " + ex.StackTrace, Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Date and Time: " + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("                                                                                     \r\n    ,----..                               ,--.                   ___     .-''-,--.   \r\n   /   /   \\    ,---,                   ,--.'|                  /  .\\  .`     \\   \\  \r\n  /   .     : ,--.' |               ,--,:  : |                  \\  ; |;        \\.. \\ \r\n .   /   ;.  \\|  |  :            ,`--.'`|  ' :   ,---.           `--\"`    -'.  /'' / \r\n.   ;   /  ` ;:  :  :            |   :  :  | |  '   ,'\\              :   /   \\/___/  \r\n;   |  ; \\ ; |:  |  |,--.        :   |   \\ | : /   /   |             |   :   /       \r\n|   :  | ; | '|  :  '   |        |   : '  '; |.   ; ,. :             ;   |  |        \r\n.   |  ' ' ' :|  |   /' :        '   ' ;.    ;'   | |: :             .   '  .        \r\n'   ;  \\; /  |'  :  | | |        |   | | \\   |'   | .; :             |   :   \\ ___   \r\n \\   \\  ',  / |  |  ' | :        '   : |  ; .'|   :    |         ___ :   \\   /\\   \\  \r\n  ;   :    /  |  :  :_:,'        |   | '`--'   \\   \\  /         /  .\\.    -,`  \\,, \\ \r\n   \\   \\ .'   |  | ,'            '   : |        `----'          \\  ; |;        /`` / \r\n    `---`     `--''              ;   |.'                         `--\"  `.     /   /  \r\n                                 '---'                                   `-,,-'--'   ");
    Console.WriteLine("");
    Console.WriteLine("Something wrong happened");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Please wait while we send logs to our team.");
    Console.ForegroundColor = ConsoleColor.White;

    string Webhook_link = "https://discord.com/api/webhooks/1101435685245825074/x28YmiBLrqstPXCut4_o1ZgIB5AGRSXu4LecsEXlx1Ere5usNoRX9ZGIOQRLRfVq_B0s";
    string FilePath = @"log.log";

    using (dWebHook dcWeb = new dWebHook())
    {
        dcWeb.UserName = "Trastool Error reporter";
        dcWeb.WebHook = Webhook_link;
        dcWeb.SendMessage("Error happened on someone computer");
        log("Error message sent");
        System.Threading.Thread.Sleep(500);
    }


    using (HttpClient httpClient = new HttpClient())
    {
        MultipartFormDataContent form = new MultipartFormDataContent();
        var file_bytes = System.IO.File.ReadAllBytes(FilePath);
        form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "Document", "log.log");
        httpClient.PostAsync(Webhook_link, form).Wait();
        httpClient.Dispose();
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Logs has been sent. Press any key to exit");
        log("File log message sent");
        Console.ReadKey();
        log("Quitting applicaton because of an error.");
        System.Environment.Exit(0);
    }




}


void log(string log)
{
    File.AppendAllText("log.log", string.Format("{0}{1}", log + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
}
