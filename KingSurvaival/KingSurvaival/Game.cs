using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KingSurvaival;

namespace KingSurvival
{
    class Game
    {
        static int size = 8;
        static King car = new King(4, 7);


        
        static Pawn peshkaA = new Pawn(1, 0);
        
        static Pawn peshkaB = new Pawn(3, 0);
        
        static Pawn peshkaC = new Pawn(5, 0);
        
        static Pawn peshkaD = new Pawn(7, 0);
        
        static bool isKingTurn = true;


        
        static void Print(char[,] matrix)
        {
        
            Console.Clear();
            
            for (int i = 0; i < size; i++)
            
            {
            
                for (int j = 0; j < size; j++)
                
                {
                
                    Console.Write("{0,2}", matrix[i, j]);
                }


               
                Console.WriteLine("");
           
            }


        }
        static void KingMove(int dirX, int dirY, char[,] matrica)
        {

            if (car.Point.X + dirX < 0 || car.Point.X + dirX > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = true;
                return;
            }

            if (car.Point.Y + dirY < 0 || car.Point.Y + dirY > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = true;
                return;
            }
            if (matrica[car.Point.Y + dirY, car.Point.X + dirX] == 'A') 
            {
                matrica[car.Point.Y + dirY, car.Point.X + dirX] = 'K';
                matrica[peshkaA.Point.Y, peshkaA.Point.X] = '-';
            }
            if (matrica[car.Point.Y + dirY, car.Point.X + dirX] == 'B')
            {
                matrica[car.Point.Y + dirY, car.Point.X + dirX] = 'K';
                matrica[peshkaB.Point.Y, peshkaB.Point.X] = '-';
            }
            if (matrica[car.Point.Y + dirY, car.Point.X + dirX] == 'C')
            {
                matrica[car.Point.Y + dirY, car.Point.X + dirX] = 'K';
                matrica[peshkaC.Point.Y, peshkaC.Point.X] = '-';
            }
            if (matrica[car.Point.Y + dirY, car.Point.X + dirX] == 'D')
            {
                matrica[car.Point.Y + dirY, car.Point.X + dirX] = 'K';
                matrica[peshkaD.Point.Y, peshkaD.Point.X] = '-';
            }
            matrica[car.Point.Y, car.Point.X] = '-';
            matrica[car.Point.Y + dirY, car.Point.X + dirX] = 'K';
            car.Point.Y += dirY;
            car.Point.X += dirX;
            return;
        }
        //abe tuka sym gi napravil edni... ama raboti
        //kvo kat sa 4 metoda
        static bool PawnAMove(int dirX, int dirY, char[,] matrix)
        {
            //sledvat mnogo proverki
            if (peshkaA.Point.X + dirX < 0 || peshkaA.Point.X + dirX > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
                
            }

            if (peshkaA.Point.Y + dirY < 0 || peshkaA.Point.Y + dirY > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }
            if (matrix[peshkaA.Point.Y + dirY, peshkaA.Point.X + dirX] == 'K')
            {
                Console.WriteLine("Pawn`s win!");
                return true;
            }
            if (matrix[peshkaA.Point.Y + dirY, peshkaA.Point.X + dirX] == 'D' || matrix[peshkaA.Point.Y + dirY, peshkaA.Point.X + dirX] == 'B'
                                                             || matrix[peshkaA.Point.Y + dirY, peshkaA.Point.X + dirX] == 'C')
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }

            //ako ne grymne do momenta znachi e validen hoda
           
            matrix[peshkaA.Point.Y, peshkaA.Point.X] = '-';
            matrix[peshkaA.Point.Y + dirY, peshkaA.Point.X + dirX] = 'A';
            peshkaA.Point.Y += dirY;
            peshkaA.Point.X += dirX;
            return false;
        }
        static bool PawnBMove(int dirX, int dirY, char[,] matrix)
        {//za dokumentaciq pregledai PawnAMove
            if (peshkaB.Point.X + dirX < 0 || peshkaB.Point.X + dirX > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }

            if (peshkaB.Point.Y + dirY < 0 || peshkaB.Point.Y + dirY > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }
            if (matrix[peshkaB.Point.Y + dirY, peshkaB.Point.X + dirX] == 'K')
            {
                Console.WriteLine("Pawn`s win!");
                return true;
            }

            if (matrix[peshkaB.Point.Y + dirY, peshkaB.Point.X + dirX] == 'A' || matrix[peshkaB.Point.Y + dirY, peshkaB.Point.X + dirX] == 'C' 
                || matrix[peshkaB.Point.Y + dirY, peshkaB.Point.X + dirX] == 'D')
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }
            matrix[peshkaB.Point.Y, peshkaB.Point.X] = '-';
            matrix[peshkaB.Point.Y + dirY, peshkaB.Point.X + dirX] = 'B';
            peshkaB.Point.Y += dirY;
            peshkaB.Point.X += dirX;
            return false;
        }
        static bool PawnCMove(int dirX, int dirY, char[,] matrix)
        {//za dokumentaciq pregledai PawnAMove
            if (peshkaC.Point.X + dirX < 0 || peshkaC.Point.X + dirX > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }
            if (peshkaC.Point.Y + dirY < 0 || peshkaC.Point.Y + dirY > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }
            if (matrix[peshkaC.Point.Y + dirY, peshkaC.Point.X + dirX] == 'K')
            {
                Console.WriteLine("Pawn`s win!");
                return true;
            }
            if (matrix[peshkaC.Point.Y + dirY, peshkaC.Point.X + dirX] == 'A' || matrix[peshkaC.Point.Y + dirY, peshkaC.Point.X + dirX] == 'B'
                || matrix[peshkaC.Point.Y + dirY, peshkaC.Point.X + dirX] == 'D')
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }

            matrix[peshkaC.Point.Y, peshkaC.Point.X] = '-';
            matrix[peshkaC.Point.Y + dirY, peshkaC.Point.X + dirX] = 'C';
            peshkaC.Point.Y += dirY;
            peshkaC.Point.X += dirX;
            return false;
        }
        static bool PawnDMove(int dirX, int dirY, char[,] matrix)
        {//za dokumentaciq pregledai PawnAMove
            if (peshkaD.Point.Y + dirY < 0 || peshkaD.Point.Y + dirY > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }

            if (peshkaD.Point.X + dirX < 0 || peshkaD.Point.X + dirX > size - 1)
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }
            if (matrix[peshkaD.Point.Y + dirY, peshkaD.Point.X + dirX] == 'K')
            {
                Console.WriteLine("Pawn`s win!");
                return true;
            }
            if (matrix[peshkaD.Point.Y + dirY, peshkaD.Point.X + dirX] == 'A' || matrix[peshkaD.Point.Y + dirY, peshkaD.Point.X + dirX] == 'B'
                                                             || matrix[peshkaD.Point.Y + dirY, peshkaD.Point.X + dirX] == 'C')
            {
                Console.WriteLine("Invalid Move!");
                Console.WriteLine("**Press a key to continue**");
                Console.ReadKey();
                isKingTurn = false;
                return false;
            }

            matrix[peshkaD.Point.Y, peshkaD.Point.X] = '-';
            matrix[peshkaD.Point.Y + dirY, peshkaD.Point.X + dirX] = 'D';
            peshkaD.Point.Y += dirY;
            peshkaD.Point.X += dirX;
            return false;
        }

                
        static void Main()
        {
            char[,] matrica = new char[,]   {{'+','-','+','-','+','-','+','-'},
                                            {'-','+','-','+','-','+','-','+'},
                                            {'+','-','+','-','+','-','+','-'},
                                            {'-','+','-','+','-','+','-','+'},
                                            {'+','-','+','-','+','-','+','-'},
                                            {'-','+','-','+','-','+','-','+'},
                                            {'+','-','+','-','+','-','+','-'},
                                            {'-','+','-','+','-','+','-','+'}};

            
            matrica[peshkaA.Point.Y, peshkaA.Point.X] = 'A';
            matrica[peshkaB.Point.Y, peshkaB.Point.X] = 'B';
            matrica[peshkaC.Point.Y, peshkaC.Point.X] = 'C';
            matrica[peshkaD.Point.Y, peshkaD.Point.X] = 'D';
            matrica[car.Point.Y, car.Point.X] = 'K';
            Print(matrica);
            bool pobedaPeshki = false;

            while (car.Point.Y > 0 && car.Point.Y < size && !pobedaPeshki)
            {
                isKingTurn = true;
                while (isKingTurn)
                {
                    isKingTurn = false;

                    Print(matrica);
                    Console.Write("King`s Turn:");
                    string direction = Console.ReadLine();
                    if (direction == "")
                    {
                        isKingTurn = true;
                        continue;
                    }

                    direction = direction.ToUpper();

                    switch (direction)
                    {
                        case "KUL":
                            {
                                KingMove(-1, -1, matrica);
                                break;
                            }
                        case "KUR":
                            {
                                KingMove(1, -1, matrica);
                                break;
                            }
                        case "KDL":
                            {
                                KingMove(-1, 1, matrica);
                                break;
                            }
                        case "KDR":
                            {
                                KingMove(1, 1, matrica);
                                break;
                            }
                        default:
                            {
                                isKingTurn = true;
                                Console.WriteLine("Invalid input!");
                                Console.WriteLine("**Press a key to continue**");
                                Console.ReadKey();
                                break;
                            }

                    }
                }
                while (!isKingTurn)
                {
                    isKingTurn = true;
                    Print(matrica);
                    Console.Write("Pawn`s Turn:");
                    string direction = Console.ReadLine();
                    if (direction == "")
                    {
                        isKingTurn = false;
                        continue;
                    }

                    direction = direction.ToUpper();

                    switch (direction)
                    {
                        case "ADR":
                            {
                                pobedaPeshki= PawnAMove(1, 1, matrica);
                                break;
                            }
                        case "ADL":
                            {
                                pobedaPeshki = PawnAMove(-1, 1, matrica);
                                break;
                            }
                        case "BDL":
                            {
                                pobedaPeshki = PawnBMove(-1, 1, matrica);
                                break;
                            }
                        case "BDR":
                            {
                                pobedaPeshki = PawnBMove(1, 1, matrica);
                                break;
                            }
                        case "CDL":
                            {
                                pobedaPeshki = PawnCMove(-1, 1, matrica);
                                break;
                            }
                        case "CDR":
                            {
                                pobedaPeshki = PawnCMove(1, 1, matrica);
                                break;
                            }
                        case "DDR":
                            {
                              pobedaPeshki =   PawnDMove(1, 1, matrica);
                                break;
                            }
                        case "DDL":
                            {
                              pobedaPeshki = PawnDMove(-1, 1, matrica);
                                break;
                            }
                        default:
                            {
                                isKingTurn = false;
                                Console.WriteLine("Invalid input!");
                                Console.WriteLine("**Press a key to continue**");
                                Console.ReadKey();
                                break;
                            }
                    }
                    Print(matrica);
                }
            }
            if (pobedaPeshki)
            {
                Console.WriteLine("Pawn`s win!");
            }
            else
            {
                Console.WriteLine("King`s win!");
            }
        }
    }
}

        