using System.Reflection;

namespace Calculator
{

	using System;
    using System.IO;

    public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator:int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			ePower = 5,
            eSqrt = 6,
            eInverse = 7,
            eSquare = 8
        }

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		// TODO: Upgrade the version number to 3.0.1.1
		private static string versionInfo = "Calculator v2.0.1.1";

		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//

		public CalcEngine ()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion ()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate ()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat (curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber (string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}

        //
        // Called when an operator is selected (+, -, *, /,^,?,1/x,x?)
        //

        public static void CalcOperation (Operator calcOper)
        {
            firstNumber = System.Convert.ToDouble(stringAnswer);
            calcOperation = calcOper;
            stringAnswer = "";
            decimalAdded = false;
        }
        private void SqrtButton_Click(object sender, EventArgs e)
        {
            
        }
        //
        // Called when the +/- key is pressed.
        //

        public static string CalcSign ()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble (stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}
		
			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal ()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ".";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumber = System.Convert.ToDouble (stringAnswer);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;

                    case Operator.eSquare:
                        numericAnswer = firstNumber * firstNumber;
                        validEquation = true;
                        break;

                    case Operator.ePower:
                        numericAnswer = Math.Pow(firstNumber, secondNumber);
                        validEquation = true;
                        break;
                    case Operator.eInverse:
                        if (firstNumber != 0)
                        {
                            numericAnswer = 1 / firstNumber;
                            validEquation = true;
                        }
                        else
                        {
                            stringAnswer = "Error"; // divide by 0
                            validEquation = false;
                        }
                        break;
                    case Operator.eSqrt:
                        numericAnswer = Math.Sqrt(firstNumber);
                        validEquation = true;
                        break;

                    default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString (numericAnswer);
			}
            

            return (stringAnswer);
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}
	}
}