using System;

public class ajaxtype()
{
	public void ajax()
    {
        if (Request.Form["a"] != null && Request.Form["b"] != null)
        {
            int a = int.Parse(Request.Form["a"]);
            int b = int.Parse(Request.Form["b"]);
            int sum = a + b;
            console.Write("The Sum is " + sum);
            // System.Threading.Thread.Sleep(5000);
        }
        return;
    }
}
