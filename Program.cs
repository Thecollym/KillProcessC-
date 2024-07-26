using System;
using System.Diagnostics;

class StopTask
{ 
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        processName = ["msedge","brave"];
     

        foreach (var process in Process.GetProcessesByName(processName))
        {
            try
            {
                process.Kill();
                Console.WriteLine($"Proceso {processName} (ID: {process.Id}) detenido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo detener el proceso {processName} (ID: {process.Id}): {ex.Message}");
            }
        }
    }
}
