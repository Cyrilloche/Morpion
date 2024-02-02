namespace Jeu_du_Morpion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Jeu du moprion*/

            /* CONDITIONS DE VICTOIRE
             * Le premier du remplis une ligne (verticale, horizontale, ou diagonale) gagne
             * somme de la ligne, colonne ou diago = 3 ou -3*/
            /* Victoire final = 3 parties gagnées*/


            /* TO DO 
             * Création d'une grille de 3x3 (tableau en 2D)*/
            /* Création des icônes de jeu */
            /* Création de la liste des joueurs (2 min)*/
            /* Attribution des icônes aux joueurs */
            /* Détermination par le hasard de qui commence (type lancés de dés)*/
            /* Comment les joueurs placent leur pion à chaque tour ?
             * - Option1 : coordonnées
             * - Option2 : cliquable dans la console*/
            /* Création d'un compteur de score pour dire si victoire total */


        }
        public static List<string> ListOfPlayers()
        {
            List<string> listOfPlayers = new List<string>();
            int numberOfPlayers = 0;
            int numberMaximumOfPlayers = 2;

            Console.WriteLine("Bienvenue dans le jeu du Morpion\nVous allez entrer vos noms l'un après l'autre");

            while (numberOfPlayers != numberMaximumOfPlayers)
            {
                numberOfPlayers++;
                Console.WriteLine("Entrer votre nom: ");
                string name = Console.ReadLine();
                listOfPlayers.Add(name);
            }
            return listOfPlayers;
        }

        public static int WhoStartInFirst()
        {
            Random rand = new Random();
            int hazard = rand.Next(1, 7);
            return hazard;
        }
        public static void Display()
        {
            int[] place = Emplacement();

            char[,] gameBoard = {
                {'.', ' ', '|', ' ', '.', ' ', '|', ' ', '.'},
                {'-', ' ', '|', ' ', '-', ' ', '|', ' ', '-'},
                {'.', ' ', '|', ' ', '.', ' ', '|', ' ', '.'},
                {'-', ' ', '|', ' ', '-', ' ', '|', ' ', '-'},
                {'.', ' ', '|', ' ', '.', ' ', '|', ' ', '.'}
            };

            while (true)
            {
                place = Emplacement();

                for (int i = 0; i < gameBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < gameBoard.GetLength(1); j++)
                    {
                        if (place[0] == j && place[1] == i)
                        {
                            gameBoard[i, j] = '#';
                        }
                        else if (gameBoard[i, j] != '#' || gameBoard[i, j] != 'X')
                        {
                            Console.Write(gameBoard[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
        public static int ChoosePosition()
        {
            char[,] board1 = {
                {'1', ' ', '|', ' ', '2', ' ', '|', ' ', '3'},
                {'-', ' ', '|', ' ', '-', ' ', '|', ' ', '-'},
                {'4', ' ', '|', ' ', '5', ' ', '|', ' ', '6'},
                {'-', ' ', '|', ' ', '-', ' ', '|', ' ', '-'},
                {'7', ' ', '|', ' ', '8', ' ', '|', ' ', '9'}
            };
            for (int i = 0; i < board1.GetLength(0); i++)
            {
                for (int j = 0; j < board1.GetLength(1); j++)
                {
                    Console.Write(board1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("En quelle position voulez-vous placer votre pion ?");
            int position = int.Parse(Console.ReadLine());
            return position;
        }

        public static int[] Emplacement()
        {
            int position = ChoosePosition();
            int[] emplacement = new int[2];

            switch (position)
            {
                case 1:
                    emplacement[0] = 0;
                    emplacement[1] = 0;
                    break;
                case 2:
                    emplacement[0] = 4;
                    emplacement[1] = 0;
                    break;
                case 3:
                    emplacement[0] = 8;
                    emplacement[1] = 0;
                    break;
                case 4:
                    emplacement[0] = 0;
                    emplacement[1] = 2;
                    break;
                case 5:
                    emplacement[0] = 4;
                    emplacement[1] = 2;
                    break;
                case 6:
                    emplacement[0] = 8;
                    emplacement[1] = 2;
                    break;
                case 7:
                    emplacement[0] = 0;
                    emplacement[1] = 4;
                    break;
                case 8:
                    emplacement[0] = 4;
                    emplacement[1] = 4;
                    break;
                case 9:
                    emplacement[0] = 8;
                    emplacement[1] = 4;
                    break;
                default:
                    break;
            }
            return emplacement;
        }
    }
}
