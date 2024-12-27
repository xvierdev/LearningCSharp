Console.Write("How many room will rented? ");
string? Q = Console.ReadLine();
Room[] quarto = new Room[10];
if (Q != null)
{
    int qtdRooms = int.Parse(Q);
    for (int i = 0; i < qtdRooms; i++)
    {
        string? room;
        string? nome;
        string? email;
        Console.WriteLine($"Rent #{i+1}");
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
        Console.Write("Room: ");
        room = Console.ReadLine();
        if (room != null){
            quarto[int.Parse(room)-1].Occuped = 1;
            quarto[int.Parse(room)-1].Nome = nome;
            quarto[int.Parse(room)-1].Email = email;
        }
        Console.WriteLine();
    }

    int qtd = 1;
    foreach(Room room in quarto){
        if(room.Occuped == 1){
            Console.Write($"{qtd}: {room.Nome}, {room.Email}\n");
        }
        qtd++;
    }
}
struct Room
{
    public int Occuped;
    public string? Nome;
    public string? Email;
}
