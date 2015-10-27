using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrDiary
{
    class ExerciseList : List<Exercise>
    {
        public ExerciseList()
        {
            this.Add(new Exercise() { ExName = "Планка" });
            this.Add(new Exercise() { ExName = "Пресс" });
            this.Add(new Exercise() { ExName = "Обратное скручивание" });
            this.Add(new Exercise() { ExName = "Упражнение гимназиста" });
        }
    }
}
