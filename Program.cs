    Console.Clear();
int valorGlicemia;
    Console.ForegroundColor = ConsoleColor.DarkMagenta; 
    Console.WriteLine("--- Diagnóstico de Diabetes Gestacional ---");
    Console.ResetColor();
    Console.Write("\nGlicemia em mg/dL...: ");
    valorGlicemia = Convert.ToInt32(Console.ReadLine());

    if (valorGlicemia < 92) 
    {
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.WriteLine("\nReavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
    Console.ResetColor();
    }
    
    else if (valorGlicemia > 91 && valorGlicemia < 126)
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nCompatível com Diabetes Gestacional");   
    Console.ResetColor();
    }
    
    else 
    {
      Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nDiabetes Mellitus na Gravidez");
      Console.ResetColor();
    } 
