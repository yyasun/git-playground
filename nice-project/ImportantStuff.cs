namespace NiceProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ImportantStuff
    {
        public int DoWhatNeedsToBeDone(IFileReader fileReader)
        {
            var allNumbers = fileReader.ReadAllNumbers();
            var sum = CalculateSumOf(allNumbers);

            return sum;
        }

        private int CalculateSumOf(IEnumerable<int> allNumbers)
        {
<<<<<<< HEAD
            var sum = 0;
            foreach (var number in allNumbers)
            {
                sum += number;
            }

            return sum;
=======
            return allNumbers.Sum();
>>>>>>> origin/merge-conflict-branch
        }
    }
}