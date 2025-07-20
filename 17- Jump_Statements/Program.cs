namespace _17__Jump_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jump Statements are used to alter the flow of control in a program.
            // - break
            // - continue
            // - goto
            // - return
            // - throw

            #region Break
            // The 'break' keyword exits the nearest enclosing loop or switch statement completely.

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break; // Exit the loop when i equals 5
            //    }
            //    Console.WriteLine(i);
            //}

            // Nested loop with break in the inner loop
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (i == 5)
            //        {
            //            break; // Breaks only the inner loop
            //        }
            //        Console.WriteLine(i + "_" + j);
            //    }
            //}
            #endregion

            #region Continue
            // The 'continue' keyword skips the current iteration and jumps to the next cycle of the loop.

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue; // Skip the rest of this iteration when i is 5
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Goto
            // The 'goto' statement transfers control to a labeled statement.

            int i = 0;

        loop:
            Console.WriteLine(i);
            i++;
            if (i < 10)
            {
                goto loop; // Jump back to the label "loop"
            }
            #endregion

            #region Throw
            // The 'throw' statement is used to signal the occurrence of an exception.

            for (i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    throw new Exception("I don't like number 5...");
                }
                Console.WriteLine(i);
            }
            #endregion

        }
    }
}
