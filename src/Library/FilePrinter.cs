using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;
// Implementacion de interfaz
public class FilePrinter : IPrinter
{
    public void PrintTicket(Recipe recipe)
    {
        File.WriteAllText("Ticket.txt", recipe.GetTextToPrint());
    }
}