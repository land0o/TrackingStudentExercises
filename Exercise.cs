
namespace StudentExercises
{
    public class CreateExercise
    {
        public string ExerciseName { get; set; }
        public string LanguageOfExercise { get; set; }
        
        public CreateExercise(string name, string language)
        {
            ExerciseName = name;
            LanguageOfExercise = language;
        }
    }
}