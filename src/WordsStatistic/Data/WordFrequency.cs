using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsStatistic.Data
{
    /// <summary>
    /// Описатель частоты слова
    /// </summary>
    public class WordFrequency
    {
        private int _count = 1;

        public int Count
        {
            get { return _count; }
        }
    }
}
