//Author          :  IGNATIOUS  MUGWAGWA

//Project title   :  MOBILE BANKING SYSTEM (CONSOLE BASED SYSTEM)

//Project Summary :  This project aims to come up with a working mobile banking system
//                   that will be able to automate some of the banking services such 
//                   as Balance Enquiry,Bank Statements Print Outs,Bank Transfers, Changing 
//                   Pin Number,Bill Payments and also to Buy Airtime using funds in 
//                   the client's bank account.

//

//Targeted Audience: The program targets to provide Banking Services to the clients
//                   by selecting from the list of services provided.



using System;

namespace Mobile
{
    // Below is the main class that have all the objects and methods prints of the program:
    class Zou
    {
        static void Main(string[] args)
        {
            string userName;

            double Amount = 500;
            double balance;

            int i = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;  // this line of code change text color

            Console.Title = " FOBS MOBILE BANKING SERVICES";
            Console.WriteLine("\tWECOME TO FOBS BANKING SERVICES");
            Console.ResetColor(); // this line of code reset color to normal

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Enter Your User Name");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;

            userName = Console.ReadLine();

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" Please Enter Your Pin Code ");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;


        x:
            int pincode = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            // code line below defines the default password that will be used: 
            if (pincode == 2018 || pincode == 1997 || pincode == 1111)
 {
        
          y:    Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(userName + "  Welcome to FOBS Banking Services  ");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("1. Balance Enquiry");
                Console.WriteLine("2. Mini Statement");
                Console.WriteLine("3. Buy Airtime");
                Console.WriteLine("4. Zesa Prepaid");
                Console.WriteLine("5. Bank transfers");
                Console.WriteLine("6. Change Pin");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;

                i = Convert.ToInt32(Console.ReadLine());

                Console.ResetColor();

                Console.Clear();

                // Balance enquiry section.
                if (i == 1)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    double charge = 0.30;
                    balance = Amount - charge;

                    Console.WriteLine("Your New Account Balance is $" + balance);

                    Console.ReadLine();

                    Console.ResetColor();


                }

                //Bank statements section.
                if (i == 2)
                {

                    Console.ForegroundColor = ConsoleColor.Red;


                    Console.WriteLine("    DATE:              **** TRANSACTIONS ****                  CURRENT BALANCE");

                    Console.WriteLine("    DATE:              Credit:          DEBIT:                 AVAILABLE BALANACE");

                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("    01/01/2018:        500.00            00.00                 500.00");
                    Console.WriteLine("    11/01/2018:         00.00            37.00                 469.00");
                    Console.WriteLine("    21/01/2018:         00.00            00.50                 468.50");
                    Console.WriteLine("    01/02/2018:        130.00            00.00                 598.50");
                    Console.WriteLine("    05/02/2018:         00.00           305.00                 293.50");
                    Console.WriteLine("    10/02/2018:         00.00            01.00                 292.50");
                    Console.WriteLine("    15/02/2018:         50.00            00.00                 343.50");
                    Console.WriteLine("    16/02/2018:         00.00            00.50                 343.00");
                    Console.WriteLine("    28/02/2018:         00.00           343.00                  00.50");
                    Console.WriteLine("    01/03/2018:         00.00            00.50                  00.00");
                    Console.WriteLine("    01/03/2018:         00.00            00.50                 " + Amount);

                    Console.ReadLine();

                    Console.ResetColor();

                }
                //Buy airtime section.
                if (i == 3)
                {

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Please select from options below");

                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("1. Buy for your self");
                    Console.WriteLine("2. Buy for other");

                    Console.ResetColor();


                    Console.ForegroundColor = ConsoleColor.Green;

                    int z = Convert.ToInt32(Console.ReadLine());

                    Console.ResetColor();

                    Console.Clear();


                    if (z == 1)
                    {
                        int amount;


                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Enter amount");

                        Console.ResetColor();


                        Console.ForegroundColor = ConsoleColor.Green;

                        amount = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();

                        Console.Clear();


                        Console.ForegroundColor = ConsoleColor.Red;

                        balance = Amount - amount;


                        Console.WriteLine("Airtime Purchase worth $ " + amount + "  was successfull");

                        Console.WriteLine("Your New Account balance is : $" + balance);

                    //    Console.ReadLine();

                        Console.ResetColor();

                    }

                    if (z == 2)
                    {
                        int phoneNumer;
                        int amount2;


                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Enter Phone Number");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        phoneNumer = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Enter Amount");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        amount2 = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        balance = Amount - amount2;


                        Console.WriteLine("Airtime worth  $ " + amount2 + " dollars to  " + phoneNumer + "   was successfull ");

                        Console.WriteLine("Your New Account balance is : $" + balance);


                     //   Console.ReadLine();

                        Console.ResetColor();




                    }
                    else
                    {
                        Console.Clear();

                        goto y;
                    }

                }
                // Zesa Payments Section.
                if (i == 4)
                {
                    int choice1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t ZETDC PREPAID SERVICES");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("1. Purchase Token ");
                    Console.WriteLine("2. Purchase On Credit");
                    Console.WriteLine("3. Repay Previous Credit ");
                    Console.WriteLine("0. Go back to Main Menu");
                    Console.ResetColor();


                    Console.ForegroundColor = ConsoleColor.Green;
                    choice1 = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                    Console.Clear();

                    if (choice1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine(" Please Enter meter number");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        int meternumnber = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Enter Amount");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        int zesaAmount = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;

                        balance = Amount - zesaAmount;

                        Console.WriteLine("Your have successfully purchased a ZESA token worth  $ " + zesaAmount);

                        Console.WriteLine("Your New Account Balance is : $ " + balance);

                        Console.ReadLine();

                        Console.ResetColor();
                        Console.Clear();

                    }
                    if (choice1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine(" Please Enter meter number");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        int meternumnber = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Enter Amount");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        int zesaAmount = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your have successfully purchased a ZESA token worth  $ " + zesaAmount + " on credit");

                        Console.ReadLine();

                        Console.ResetColor();


                    }
                    if (choice1 == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your have successfully Repaid Previous Credit ");
                        Console.ResetColor();
                    }
                    else
                    {

                        Console.Clear();
                        goto y;
                    }







                }
                // Bank transfers section.
                if (i == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("PLEASE SELECT FROM THE LIST BELOW:");

                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("1. RTGS");

                    Console.WriteLine("2. Internal transfers");

                    Console.WriteLine("3. ZIPIT");

                    Console.WriteLine("0. Main Menu");

                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;

                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.ResetColor();

                    Console.Clear();

                    if (n == 1)
                    {


                        Console.ForegroundColor = ConsoleColor.Red;

                    d: Console.WriteLine("PLEASE SELECT FROM THE LIST BELOW:");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine("1.      AGRI  BANK");

                        Console.WriteLine("2.      BARCLAS BANK");

                        Console.WriteLine("3.      BANC ABC BANK");

                        Console.WriteLine("4.      CABS");

                        Console.WriteLine("5.      CBZ BANK");

                        Console.WriteLine("6.      CENTRAL BANK");

                        Console.WriteLine("7.      FBC BANK");

                        Console.WriteLine("8.      STANBIC BANK");

                        Console.WriteLine("9.      STEWARD BANK");

                        Console.WriteLine("10.     STANDARD BANK");

                        Console.WriteLine("11.     MET BANK");

                        Console.WriteLine("12.     NED  BANK");

                        Console.WriteLine("13.     POSB BANK");

                        Console.WriteLine("14.     ZB BANK");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        int answer = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();
                        Console.Clear();

                        if (answer == 1 || answer <= 14)
                        {
                            Console.Clear();

                            string beneficiaryname1;
                            string paymentreason1;
                            int accountnumber;
                            double amount;

                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Enter beneficiary name");

                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;

                            beneficiaryname1 = Console.ReadLine();

                            Console.ResetColor();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Enter reason for payment");

                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;

                            paymentreason1 = Console.ReadLine();

                            Console.ResetColor();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Enter Beneficiary Account Number");

                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;

                            accountnumber = Convert.ToInt32(Console.ReadLine());

                            Console.ResetColor();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Red;

                        g: Console.WriteLine("Enter Amount");

                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;

                            amount = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();

                            if (amount < 1.00 || amount > Amount)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine("Your Amount is Invalid or above the Float please Re-enter the amount"); goto g;


                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                Console.WriteLine("  1.Enter Confirm  \n  2.Cancel");
                                int confirm = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (confirm == 1)
                                {

                                    double charge = 5.00;
                                    balance = Amount - (charge + amount);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" RTGS Transfer  to  " + accountnumber + " of $ " + amount + " Was successfull");

                                    Console.WriteLine(" Your New Account Balance is : $ " + balance);
                                    Console.ReadLine();
                                    Console.ResetColor();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine(" \tResult Unknown!!!  "); goto k;
                                }

                            }




                        }
                        else
                        {
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Result Unknown!!!!");

                            goto d;


                        }


                    }




                    if (n == 2)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Enter Account Number");

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;


                        int accountNumber = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;

                    i: Console.WriteLine("Enter Amount");

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;

                        int amount5 = Convert.ToInt32(Console.ReadLine());

                        if (amount5 < 1.00 || amount5 > Amount)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Your Amount is Invalid or above the Float please Re-enter the amount"); goto i;


                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine("  1.Enter Confirm  \n  2.Cancel");
                            int confirm = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (confirm == 1)
                            {

                                double charge = 3.00;
                                balance = Amount - (charge + amount5);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Your Internal transfer to  " + accountNumber + "   of $ " + amount5 + "   was successfull");

                                Console.WriteLine(" Your New Account Balance is : $ " + balance);
                                Console.ReadLine();
                                Console.ResetColor();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" \tResult Unknown!!!  "); goto k;

                            }

                        }

                        if (n == 3)
                        {
                          //  Console.Clear();

                        p: Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("PLEASE SELECT FROM THE LIST BELOW:");

                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine("1.      AGRI  BANK");

                            Console.WriteLine("2.      BARCLAS BANK");

                            Console.WriteLine("3.      BANC ABC BANK");

                            Console.WriteLine("4.      CABS");

                            Console.WriteLine("5.      CBZ BANK");

                            Console.WriteLine("6.      CENTRAL BANK");

                            Console.WriteLine("7.      FBC BANK");

                            Console.WriteLine("8.      STANBIC BANK");

                            Console.WriteLine("9.      STEWARD BANK");

                            Console.WriteLine("10.     STANDARD BANK");

                            Console.WriteLine("11.     MET BANK");

                            Console.WriteLine("12.     NED  BANK");

                            Console.WriteLine("13.     POSB BANK");

                            Console.WriteLine("14.     ZB BANK");

                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Green;

                            int bankChoice = Convert.ToInt32(Console.ReadLine());

                            Console.ResetColor();
                            Console.Clear();

                            if (bankChoice == 1 || bankChoice <= 14)
                            {
                                Console.Clear();

                                string paymentreason;
                                string beneficiaryname;
                                int accountNumber2;
                                double amount4;


                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Enter beneficiary name");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;

                                beneficiaryname = Console.ReadLine();

                                Console.ResetColor();
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Enter reason for payment");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;

                                paymentreason = Console.ReadLine();

                                Console.ResetColor();
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Enter Beneficiary Account Number");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;

                                accountNumber2 = Convert.ToInt32(Console.ReadLine());

                                Console.ResetColor();
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Enter Amount");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;

                            e: amount4 = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();

                                if (amount4 < 1.00 || amount4 > Amount)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("Your Amount is Invalid or above the Float please Re-enter the amount"); goto e;


                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;

                                    Console.WriteLine("  1.Enter Confirm  \n  2.Cancel");
                                    int confirm = int.Parse(Console.ReadLine());
                                    Console.Clear();

                                    if (confirm == 1)
                                    {

                                        double charge = 3.00;
                                        balance = Amount - (charge + amount4);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" ZIPIT Transfer  to  " + accountNumber2 + " of $ " + amount4 + " Was successfull");

                                        Console.WriteLine(" Your New Account Balance is : $ " + balance);

                                        Console.ReadLine();
                                        Console.ResetColor();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine(" \tResult Unknown!!!  "); goto k;
                                    }

                                }




                            }
                            else
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Result Unknown!!!!");

                                goto p;



                            }


                        }


                        if (n == 0)
                        {
                            goto y;
                        }

                    }
                    // Change pin section.
                    if (i == 6)
                    {
                        int newpin;
                        Console.ForegroundColor = ConsoleColor.Red;


                        Console.WriteLine("Enter New Pin Number");

                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;

                        newpin = Convert.ToInt32(Console.ReadLine());

                        Console.ResetColor();
                        Console.Clear();


                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Pin has been changed successfull");

                        Console.ResetColor();

                        Console.ReadLine();

                    }

 }



                else // This code section enables the user to try his password if he inputs the wrong one:
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Wrong pincode please re-enter", pincode); goto x;



                }


                // this section show how the program ends:
          k:    Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\tThank you " + userName + "  for using our FOBS Mobile Banking Services ");

                Console.ResetColor();
                Console.ReadLine();

            }
        }

    }
}