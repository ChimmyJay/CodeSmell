using System;

namespace CodeSmell.Banks
{
    internal class ESunBank
    {
        public void GetHistories(string startDate, string endDate)
        {
            var start = DateTime.Parse(startDate);
            var end = DateTime.Parse(endDate);

            if (start > end)
            {
                throw new InvalidOperationException();
            }

            throw new NotImplementedException();
        }

        public void GetCreditCardPayHistories(string startDate, string endDate)
        {
            var start = DateTime.Parse(startDate);
            var end = DateTime.Parse(endDate);

            if (start > end)
            {
                throw new InvalidOperationException();
            }

            throw new NotImplementedException();
        }
    }
}