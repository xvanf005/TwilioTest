using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class SMSsender
{
    static void Main(string[] args)
    {
        //údaje z Twilio účtu
        string accountSid = "AC50a7eb2f7966b4ab3c95928c7a953c99";
        string authToken = "62a2bfc39aa6184974c9746e00335a53";

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