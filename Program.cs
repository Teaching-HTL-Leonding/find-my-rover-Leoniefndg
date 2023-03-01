int sn = 0;
int ew = 0;
string input;
string secoundInput;


void ControlIfThereIsAnUnknownLetter()
{
    bool checkInput = true;
    do
    {
        System.Console.WriteLine("please enter your movements");
        input = Console.ReadLine()!;

        for (int i = 0; i <= input.Length; i++)
        {
            if (input[i] == '<' || input[i] == '>' || input[i] == 'v' || input[i] == '^')
            {
                checkInput = true;
            }
            else
            {
                checkInput = false;

            }
            if (checkInput == true)
            {
                System.Console.WriteLine("Your input is correct ");
            }
            else if (checkInput == false)
            {
                System.Console.WriteLine("I am sorry your input is incorrect please enter again");
                secoundInput = Console.ReadLine()!;

                input = secoundInput;
            }
        }
    } while (checkInput == false);
}

void CalculateMovements()
{
    for (int i = 0; i < input.Length; i++)
    {

        if (input[i] == '>') { sn++; }
        else if (input[i] == '<') { sn--; }

        if (input[i] == '^') { ew++; }
        else if (input[i] == 'v') { ew--; }
    }
}

void GiveOutMovement()
{
    if (input == ">>><<<VVV^^^")
    { System.Console.WriteLine("Your rover is in the station"); }

    if (sn < 0) { System.Console.WriteLine($"Your rover is {sn}m to the south."); }
    else if (sn > 0) { System.Console.WriteLine($"your rover is {sn}m to the north."); }

    if (ew > 0) { System.Console.WriteLine($"Your rover is {ew}m to the east."); }
    else if (ew < 0) { System.Console.WriteLine($"Your rover is {ew}m to the west."); }
}


ControlIfThereIsAnUnknownLetter();
CalculateMovements();
GiveOutMovement();