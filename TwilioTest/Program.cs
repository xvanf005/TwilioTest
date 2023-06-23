using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class SMSsender
{
    static void Main(string[] args)
    {
        //údaje z Twilio účtu
        string accountSid = "";
        string authToken = "";

        //odkaz na Twilio
        TwilioClient.Init(accountSid, authToken);
        Console.WriteLine("napište zprávu příjemci");

        //vytvoření zprávy
        var message = MessageResource.Create(
            body: Console.ReadLine(),
            from: new Twilio.Types.PhoneNumber("+18316071992"),
            to: new Twilio.Types.PhoneNumber("+420607148139")
        );

        Console.WriteLine("Zpráva byla úspěšně odeslána");
    }
}