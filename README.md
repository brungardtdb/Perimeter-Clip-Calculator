# Perimeter-Clip-Calculator
A C# console application that calculates the number of perimeter clips on a concealed fastener roof for a roof sheeting plan
based on user input. The application takes the edge zone called out by the engineer, subtracts the start / finish dimension
for the roof sheeting, then divides that number by 24" to obtain the number of panels in the corner zone. The application then
takes the number of panels + 1 to account for the perimeter clip at the next panel lap outside of the corner zone (so the entire
corner zone is accounted for). That number accounts for all the perimeter clips along one purlin. The user is then prompted to 
enter the vertical edge zone dimension. The user is then prompted to enter purlin spaces on the roof in inches with a loop. This loop terminates when the purlin space total inches exceed the vertical corner zone dimension given (in inches). The loop uses a counter to keep track of the quantity of purlin spaces in the vertical edge zone dimension, and multiplies the quantity of perimeter clips on each purlin by that number to calculate the total number of perimeter clips in the edge zone. 
