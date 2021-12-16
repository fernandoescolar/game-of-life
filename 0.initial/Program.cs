const int Heigth = 20;
const int Width = 40;

var cells  = new bool[Heigth, Width];
var active = true;

// initialize cells
var rnd = new Random();
for (int i = 0; i < Heigth; i++)
{
    for (int j = 0; j < Width; j++)
    {
        cells[i, j] = rnd.NextDouble() < 0.2;
    }
}

Console.Clear();

while (active)
{
    // draw cells
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < cells.GetLength(0); i++)
    {
        for (int j = 0; j < cells.GetLength(1); j++)
        {
            Console.Write(cells[i, j] ? "*" : " ");
        }

        Console.Write("\n");
    }

    // hack: give some time to the terminal to draw it
    Console.Out.Flush();
    Thread.Sleep(500);

    // calculate next generation
    var next = new bool[Heigth, Width];
    for (int i = 0; i < Heigth; i++)
    {
        for (int j = 0; j < Width; j++)
        {
            // get neighbors
            var neighbors = 0;
            for (int k = -1; k <= 1; k++)
            {
                for (int l = -1; l <= 1; l++)
                {
                    if (k == 0 && l == 0) continue;
                    if (i + k < 0 || i + k >= cells.GetLength(0)) continue;
                    if (j + l < 0 || j + l >= cells.GetLength(1)) continue;
                    neighbors += cells[i + k, j + l] ? 1 : 0;
                }
            }

            // calculate next cell generation
            next[i, j] = (cells[i, j], neighbors) switch
            {
                (true, < 2) => false,
                (true, > 3) => false,
                (false, 3) => true,
                _ => cells[i, j]
            };
        }
    }

    cells = next;
}