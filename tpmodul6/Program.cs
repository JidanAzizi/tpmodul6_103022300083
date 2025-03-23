// See https://aka.ms/new-console-template for more information
using tpmodul6;

class Program {
    static void Main(   ) {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial by Jidan - Maulana Jidan Azizi");
        video.PrintVideoDetails();

        video.IncreasePlayCount(5000);
        video.PrintVideoDetails();
    }
}
