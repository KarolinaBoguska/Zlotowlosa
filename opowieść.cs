using System;

namespace klasy.Złotowłosa
{
    public class Opowieść
    {
        public void Wyświetl()
        {
            // stwórz obiekty dla klas narrator, misie złotowłosa, czynności
            Narrator narrator = new Narrator();
            // przypisz wartość do obiektów
            narrator.narrator = "NARRATOR";
            Misie mama = new Misie();
            mama.miś = "MAMA MIŚ";
            Misie tata = new Misie();
            tata.miś = "TATA MIŚ";
            Misie dziecko = new Misie();
            dziecko.miś = "MAŁY MIŚ";
            // klasa public string = new klasa
            Złotowłosa złotowłosa = new Złotowłosa();
            złotowłosa.złotowłosa = " ZŁOTOWŁOSA";
            Czynności siada = new Czynności();
            Czynności zjada = new Czynności();
            Czynności zasypia = new Czynności();


            Console.WriteLine(" ---- ZŁOTOWŁOSA ----");
            narrator.Mówi("Jest to opowieść o pewnej małej dziewczynce, która nazywała się Złotowłosa. Była bardzo ciekawa świata i cały czas spędzała poza domem, wędrując po okolicy. Pewnego dnia zauważyła w lesie śmieszny dom, okrągły jak grzybek.");
            złotowłosa.Mówi("Halo...czy jest ktoś w domu? Ale co to? Drzwi SA otwarte...Któż może tu mieszkać?...");
            narrator.Mówi("Któż mógł tu mieszkać? Na stole stały trzy filiżanki z gorącą czekoladą: duża, średnia i mała. Złotowłosa była bardzo głodna, więc spróbowała czekolady. W dużej filiżance była za gorąca, w średniej – za zimna. Dziewczynka wypiła czekoladę z małej filiżanki, bo czekolada w niej była taka, jak trzeba.");
            zjada.Zjada();
            narrator.Mówi("Przed kominkiem stały trzy krzesła: duże, średnie i małe. Wskoczyła na to duże, odbiła się na średnie, wreszcie usiadła na malutkim. I nagle bum! – krzesełko się złamało!");
            siada.Siada();
            narrator.Mówi("Złotowłosa wypróbowała wszystkie. Największe było zbyt miękkie, średnie niewygodne, najmniejsze odpowiednie.");
            zasypia.Zasypia();
            narrator.Mówi("Dziewczynka położyła się i natychmiast zasnęła. Spała tak głęboko, że nie usłyszała wracających gospodarzy. Była ich trójka. Trzy niedźwiedzie, które poszły po miód na śniadanie. Jeden niedźwiedź był duży, drugi średni, trzeci mały: byli to tata, mama i ich synek");
            tata.Mówi("Szybko! Ktoś jest w naszym domku...");
            mama.Mówi("Kto pił z mojej filiżanki?");
            dziecko.Mówi("Kto siedział na moim krześle?");
            narrator.Mówi(" Misie weszły do sypialni w poszukiwaniu obcego przybysza");
            tata.Mówi("Ktoś spał w moim łóżku");
            dziecko.Mówi("A ktoś nadal śpi w moim łóżeczku!!");
            narrator.Mówi("Złotowłosa zbudziła się gwałtownie. Przestraszywszy się groźnych spojrzeń pochylonych nad nią niedźwiedzi, najpierw podciągnęła kołdrę pod samą brodę. A potem wyskoczyła z łóżka i pędem zbiegła na dół po schodach.");
            Console.WriteLine(" THE END");
        }
    }
}