using System;
using System.Text;

public static class Program
{
    public static void Main()
    {
        foreach(EncodingInfo ei in Encoding.GetEncodings())
        {
            Encoding e = ei.GetEncoding();
            Console.WriteLine("{1}{0}" + "\tCodePage={2}, WindowsCodePage={3}{0}" + "\tWebName={4}, HeaderName={5}, BodyName={6}{0}" + "\tIsBrowserDisplay={7}, IsBrowserSave={8}{0}" + "\tIsMailNewsDisplay={9}, IsMailNewsSave={10}{0}", 
                Environment.NewLine,
                e.EncodingName, e.CodePage, e,WindowsCodePage,
                e.WebName, e.HeaderName, e.BodyName,
                e.IsBrowserDisplay, e.IsBrowserSave,
                e.IsMailNewsDisplay, e.IsMailNewsSave);
        }
    }
}