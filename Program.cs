using System;


class Program
{
    
    
    static void Main()
    {

        // Declaration Section

        Corner_Zone CornerZone1 = new Corner_Zone();    

        // Ask the user to enter a size (in inches) for the corner zone called out by design.

        Console.Write($"Please enter the horizontal zone size called out by design (inches): ");
        var zoneSize = Console.ReadLine();
        CornerZone1.ZoneSize = Convert.ToDouble(zoneSize);
        Console.WriteLine($"Horizontal zone size is: {CornerZone1.ZoneSize} inches");

        // Ask the user to enter a start/finish dimension for the sheeting plan (in inches)
        // give them an error message if the dimension smaller or larger than our standards.
        do
        {
            Console.Write($"Please enter the start dimension for the sheeting plan (inches): ");
            var startFinishDim = Console.ReadLine();
            CornerZone1.StartFinishDim = Convert.ToDouble(startFinishDim);

            if (CornerZone1.StartFinishDim < 12.125)
            {
                CornerZone1.CorrectStartFinish = false;
                Console.WriteLine($"Please enter a start dimension (inches) between 12.125 and 24.125");
            }
            else if (CornerZone1.StartFinishDim > 24.125)
            {
                CornerZone1.CorrectStartFinish = false;
                Console.WriteLine($"Please enter a start dimension (inches) between 12.125 and 24.125");
            }
            else
            {
                CornerZone1.CorrectStartFinish = true;
               
            }
            
        }
        while (CornerZone1.CorrectStartFinish == false);

        Console.WriteLine($"Start / Finish dimension is {CornerZone1.StartFinishDim} inches");

        // Based on on the corner zone dimension called out by the engineer, and the Start/Finish
        // dimension provided from the sheeting plan, calculate the number of perimeter clips per
        // purlin run on the roof sheeting plan.


        var cornerZoneActual = CornerZone1.ZoneSize - CornerZone1.StartFinishDim;

        CornerZone1.ClipsPerPurlin = Convert.ToInt32((cornerZoneActual / 24) + 1);
        Console.WriteLine($"Number of clips per purlin run: { CornerZone1.ClipsPerPurlin}");


        // Ask user for the vertical zone size called out by design (inches)
        Console.Write($"Please enter the vertical zone size called out by design (inches): ");
        var verticalZoneSize = Console.ReadLine();
        CornerZone1.VerticalZoneSize = Convert.ToDouble(verticalZoneSize);
        Console.WriteLine($"Vertical zone size is: {CornerZone1.VerticalZoneSize} inches");


        // Ask user for number of purlins and calculate the total number of perimeter clips.

        double totalPurlinInches = 0; // initialize sum of total purlin runs (inches)
        int purlinRunCounter = 0; // initialize the # of purlin runs entered so far

        // Prompt for input and read purlin runs (inches) from the user.
        Console.WriteLine($"Please enter the first purlin space (inches): ");
        double purlinRun = double.Parse(Console.ReadLine());

        do
        {
            totalPurlinInches = totalPurlinInches + purlinRun; // Add purlin run to the total
            purlinRunCounter = purlinRunCounter + 1; // increment counter

            // Prompt for input and read purlin runs (inches) from the user.
            Console.WriteLine($"Please enter the next purlin space (inches): ");
            purlinRun = double.Parse(Console.ReadLine());

            if (totalPurlinInches < CornerZone1.VerticalZoneSize)
            {
                CornerZone1.CorrectPurlinSpace = false;
            }
            else
            {
                CornerZone1.CorrectPurlinSpace = true;
            }
        }
        while (CornerZone1.CorrectPurlinSpace == false); // Terminate the loop when the purlin runs (inches) exceeds the vertial zone size. 

        // if the user entered at least one purlin run
        if (purlinRunCounter != 0)
        {
            // Calculate the total number of perimeter clips in the corner zone
            var totalPerimeterClips = purlinRunCounter * CornerZone1.ClipsPerPurlin;
            CornerZone1.TotalPerimeterClips = totalPerimeterClips;
            Console.WriteLine($" Total Perimeter Clips: {CornerZone1.TotalPerimeterClips} ");
        }
        else
        {
            Console.WriteLine("No purlin runs entered");
        }

    }
}

    

