using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

namespace Diana_FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\n\n\n");
            TypewriterEffect("\t\t\t                           ████████████╗             ████╗           █████████████╗");
            TypewriterEffect("\t\t\t                          █████╔═══════╝             ████║           ╚════████╔═══╝");
            TypewriterEffect("\t\t\t                          ████╔╝                     ████║                ████║");
            TypewriterEffect("\t\t\t                          ████║                      ████║                ████║");
            TypewriterEffect("\t\t\t                          ████║                      ████║                ████║");
            TypewriterEffect("\t\t\t                          ████║                      ████║                ████║");
            TypewriterEffect("\t\t\t                          ╚████████████╗             ████║                ████║");
            TypewriterEffect("\t\t\t                           ╚═══════════╝             ╚═══╝                ╚═══╝");
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("\t\t\t ░               ██████╗████████╗██╗   ██╗ ██████╗███████╗███╗   ██╗████████╗ █╗ █████╗               ░");
            Console.WriteLine("\t\t\t ░             ███║      ╚══██╔═╝██║   ██║██╔══██╗██╔════╝████╗  ██║╚══██╔══╝   ██║                   ░");
            Console.WriteLine("\t\t\t ░              ╚════██╗    ██║  ██║   ██║██║  ██║█████╗  ██║╚██╗██║   ██║        ╚═══██╗             ░");
            Console.WriteLine("\t\t\t ░              ███╔═██║    ██║  ╚██╗ ██╔╝██║  ██║██╔══╝  ██║╚██╗██║   ██║       ███╔═██║             ░");
            Console.WriteLine("\t\t\t ░              ██████╔╝    ██║   ╚████╔╝ ██████╔╝███████╗██║ ╚████║   ██║       ██████╔╝             ░");
            Console.WriteLine("\t\t\t ░              ╚═════╝     ╚═╝    ╚═══╝  ╚═════╝ ╚══════╝╚═╝  ╚═══╝   ╚═╝       ╚═════╝              ░");
            Console.WriteLine("\t\t\t ░                                                                                                    ░");
            Console.WriteLine("\t\t\t ░                        ██████╗  ███████╗████████╗ █████╗  ███╗ ██╔      ████╗                      ░");
            Console.WriteLine("\t\t\t ░                        ██╔══██╗ ██╔════╝╚══██╔══╝██╔══██╗ ███║ ██║    ███║                         ░");
            Console.WriteLine("\t\t\t ░                        ██║  ██║ █████╗     ██║   ███████║ ███║ ██║       ╚═██╗                     ░");
            Console.WriteLine("\t\t\t ░                        ██║  ██║ ██╔══╝     ██║   ██╔══██║ ███║ ██║     ██╔═██║                     ░");
            Console.WriteLine("\t\t\t ░                        ██████╔╝ ███████╗   ██║   ██║  ██║ ███║ ██║     █████╔╝                     ░");
            Console.WriteLine("\t\t\t ░                        ╚═════╝  ╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚══╝ ██████╗ ╚════╝                      ░");
            Console.WriteLine("\t\t\t ░                                                                                                    ░");
            Console.WriteLine("\t\t\t ░    ███╗   ███╗ █████╗ ███╗   ██╗ █████╗  ██████╗ ███████╗███╗   ███╗███████╗███╗   ██╗████████╗    ░");
            Console.WriteLine("\t\t\t ░    ████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝ ██╔════╝████╗ ████║██╔════╝████╗  ██║╚══██╔══╝    ░");
            Console.WriteLine("\t\t\t ░    ██╔████╔██║███████║██╔██╗ ██║███████║██║      █████╗  ██╔████╔██║█████╗  ██╔██╗ ██║   ██║       ░");
            Console.WriteLine("\t\t\t ░    ██║╚██╔╝██║██╔══██║██║╚██╗██║██╔══██║██║  ███╗██╔══╝  ██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║       ░");
            Console.WriteLine("\t\t\t ░    ██║ ╚═╝ ██║██║  ██║██║ ╚████║██║  ██║██║   ██║███████╗██║ ╚═╝ ██║███████╗██║ ╚████║   ██║       ░");
            Console.WriteLine("\t\t\t ░    ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ██████╔╝╚══════╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝       ░");
            Console.WriteLine("\t\t\t ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            TypewriterEffect("\n\t\t\t Ready? Okay");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();

            Thread.Sleep(800);
            Console.Clear();

            Console.Write("\n\n\n");
            Console.WriteLine("\t\t\tAre you a Parent or Teacher? (1 if Parent and 2 if Teacher)");
            Console.Write("\t\t\t\tEnter choice: ");

            if (int.TryParse(Console.ReadLine(), out int userType))
            {
                IUser user = null;

                if (userType == 2)
                {
                    user = new Teacher();
                }
                else if (userType == 1)
                {
                    user = new Parent(new List<Student>());
                }
                else
                {
                    Console.WriteLine("\t\t\t\tInvalid input.");
                    return;
                }

                user.ShowOptions();
            }
            else
            {
                Console.WriteLine("\t\t\t\tInvalid input. Please enter a number.");
            }
        }
        static void TypewriterEffect(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);  
                Thread.Sleep(20);   
            }

            Console.WriteLine();  
        }
    }
    public interface IUser
    {
        void ShowOptions();
    }
    public abstract class User : IUser
    {
        public abstract void ShowOptions();
    }

    public class Teacher : User
    {
        private const string FilePath = @"C:\Users\LATITUDE\Documents\mama&papa\Yanna Da Great\Final Project\Students\Student.txt";
        private List<Student> students = new List<Student>();

        public Teacher()
        {
            LoadData();
        }
        public override void ShowOptions()
        {
            bool ContinueProgram = true;
            Thread.Sleep(800);
            Console.Clear();
            while (ContinueProgram)
            {
                Console.Write("\n\n\n");
                Console.WriteLine("\t\t\t1. Add a new student");
                Console.WriteLine("\t\t\t2. Find details using LRN");
                Console.WriteLine("\t\t\t3. Find details using name");
                Console.WriteLine("\t\t\t4. Delete student details");
                Console.WriteLine("\t\t\t5. Update student details");
                Console.WriteLine("\t\t\t6. Show List of all the Students");
                Console.WriteLine("\t\t\t7. Show student's grade card");
                Console.WriteLine("\t\t\t8. Exit");
                Console.Write("\t\t\tEnter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\n\t\t\tInvalid choice. Please enter a number.");
                    Thread.Sleep(800);
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        FindStudentByLRN();
                        break;
                    case 3:
                        FindStudentByName();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        UpdateStudent();
                        break;
                    case 6:
                        ShowAllStudents();
                        break;
                    case 7:
                        ShowGradeCard();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("\n\t\t\tInvalid choice. Please try again.");
                        break;
                }
                if (choice == 2 || choice == 3 || choice == 6 || choice == 7)
                {
                    string response;
                    do
                    {
                        Console.Write("\n\t\t\tReady to enter another choice? [Y/N]: ");
                        response = Console.ReadLine()?.Trim().ToUpper();

                        if (response != "Y" && response != "N")
                        {
                            Console.WriteLine("\n\t\t\tPick a valid choice: Y/N");
                        }
                    }
                    while (response != "Y" && response != "N");

                    if (response == "N")
                    {
                        ContinueProgram = false;
                    }
                }

                Thread.Sleep(800);
                Console.Clear();
            }
        }
        private string GetStudentFolderPath(Student student)
        {
            string baseDir = @"C:\Users\LATITUDE\Documents\mama&papa\Yanna Da Great\Final Project\Students\";
            string studentFolderName = student.Name.Replace(" ", "_");
            string folderPath = Path.Combine(baseDir, studentFolderName);

            return folderPath;
        }

        private void SaveData()
        {
            foreach (var student in students)
            {
                string folderPath = GetStudentFolderPath(student);
                Directory.CreateDirectory(folderPath);

                string studentFile = Path.Combine(folderPath, "student_data.txt");

                using (StreamWriter writer = new StreamWriter(studentFile, false))
                {
                    writer.WriteLine($"Name: {student.Name}");
                    writer.WriteLine($"Gender: {student.Gender}");
                    writer.WriteLine($"LRN: {student.LRN}");
                    writer.WriteLine();


                    foreach (var subject in student.Subjects)
                    {
                        subject.CalculateGrades();
                    }

                    for (int quarter = 0; quarter < 4; quarter++)
                    {
                        writer.WriteLine($"QUARTER {quarter + 1}");

                        foreach (var subject in student.Subjects)
                        {
                            writer.WriteLine($"  {subject.Name}");
                            writer.WriteLine($"    Quiz Scores: {string.Join(", ", subject.QuarterlyQuizScores[quarter])}");
                            writer.WriteLine($"    Activity Scores: {string.Join(", ", subject.QuarterlyActivityScores[quarter])}");
                            writer.WriteLine($"    Exam Score: {subject.QuarterlyExamScores[quarter]}");
                            writer.WriteLine($"    Grade: {subject.QuarterlyGrades[quarter]:F2}");
                        }

                        double quarterGrade = student.Subjects.Average(s => s.QuarterlyGrades[quarter]);
                        writer.WriteLine($"  Quarter Grade: {quarterGrade:F2}");
                    }

                    writer.WriteLine("FINAL GRADES");
                    foreach (var subject in student.Subjects)
                    {
                        writer.WriteLine($"  {subject.Name}: {subject.FinalGrade:F2}");
                    }

                    double generalAverage = student.Subjects.Average(s => s.FinalGrade);
                    writer.WriteLine($"General Average: {generalAverage:F2}");
                }
            }
        }

        private void LoadData()
        {
            students.Clear();

            string studentDataDirectory = @"C:\Users\LATITUDE\Documents\mama&papa\Yanna Da Great\Final Project\Students";

            foreach (var folderPath in Directory.GetDirectories(studentDataDirectory))
            {
                string studentFile = Path.Combine(folderPath, "student_data.txt");

                if (File.Exists(studentFile))
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(studentFile))
                        {
                            var student = new Student();
                            student.Name = reader.ReadLine()?.Split(":")[1]?.Trim();
                            student.Gender = reader.ReadLine()?.Split(":")[1]?.Trim();
                            student.LRN = reader.ReadLine()?.Split(":")[1]?.Trim();
                            reader.ReadLine();

                            student.Subjects = new List<Subject>();
                            List<string> subjectNames = new List<string>
                    {
                        "Filipino", "English", "Mathematics", "Science",
                        "Araling Panlipunan", "Edukasyon sa Pagpapakatao (ESP)", "MAPEH"
                    };

                            foreach (var subjectName in subjectNames)
                            {
                                List<int>[] defaultQuarterlyQuizScores = new List<int>[4];
                                List<int>[] defaultQuarterlyActivityScores = new List<int>[4];
                                int[] defaultQuarterlyExamScores = new int[4];

                                for (int i = 0; i < 4; i++)
                                {
                                    defaultQuarterlyQuizScores[i] = new List<int>();
                                    defaultQuarterlyActivityScores[i] = new List<int>();
                                }

                                Subject subject = new Subject(subjectName, defaultQuarterlyQuizScores, defaultQuarterlyActivityScores, defaultQuarterlyExamScores);
                                student.Subjects.Add(subject);
                            }

                            for (int quarter = 0; quarter < 4; quarter++)
                            {
                                string quarterLine = reader.ReadLine();

                                while (quarterLine != null && !quarterLine.Trim().StartsWith($"QUARTER {quarter + 1}", StringComparison.OrdinalIgnoreCase))
                                {
                                    quarterLine = reader.ReadLine();
                                }
                                if (quarterLine == null || !quarterLine.Trim().StartsWith($"QUARTER {quarter + 1}", StringComparison.OrdinalIgnoreCase))
                                {
                                    continue;
                                }

                                foreach (var subject in student.Subjects)
                                {
                                    try
                                    {

                                        string subjectNameLine = reader.ReadLine();
                                        if (subjectNameLine == null || !subjectNameLine.Contains(subject.Name))
                                        {
                                            continue;
                                        }
                                        var quizScoresLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyQuizScores[quarter] = !string.IsNullOrEmpty(quizScoresLine)
                                            ? quizScoresLine.Split(",").Select(score => int.TryParse(score.Trim(), out int result) ? result : 0).ToList()
                                            : new List<int>();


                                        var activityScoresLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyActivityScores[quarter] = !string.IsNullOrEmpty(activityScoresLine)
                                            ? activityScoresLine.Split(",").Select(score => int.TryParse(score.Trim(), out int result) ? result : 0).ToList()
                                            : new List<int>();

                                        var examScoreLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyExamScores[quarter] = !string.IsNullOrEmpty(examScoreLine) && int.TryParse(examScoreLine, out int examScore)
                                            ? examScore
                                            : 0;

                                        var gradeLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyGrades[quarter] = !string.IsNullOrEmpty(gradeLine) && double.TryParse(gradeLine, out double grade)
                                            ? grade
                                            : 0.0;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }

                            foreach (var subject in student.Subjects)
                            {
                                subject.CalculateGrades();
                            }

                            students.Add(student);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                else
                {
                }
            }
        }
        private void AddStudent()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.Write("\t\t\tEnter student name: ");
            string name = Console.ReadLine();
            string gender;
            while (true)
            {
                Console.Write("\t\t\tEnter gender (Male/Female): ");
                gender = Console.ReadLine();
                if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ||
                    gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\t\t\tInvalid input. Please enter 'Male' or 'Female'.");
                }
            }

            string lrn;
            while (true)
            {
                Console.Write("\t\t\tEnter LRN (Learner Reference Number): ");
                lrn = Console.ReadLine();

                if (lrn.Length == 12 && long.TryParse(lrn, out _))
                {
                    if (students.Any(s => s.LRN == lrn))
                    {
                        Console.WriteLine("\t\t\tThis LRN is already taken. Please enter a different LRN.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\t\t\tInvalid LRN. Please enter exactly 12 numeric digits.");
                }
            }

            List<Subject> subjects = InitializeSubjects();

            for (int quarter = 0; quarter < 4; quarter++)
            {
                Console.Clear();
                Console.WriteLine($"\n\t\t\tEntering scores for Quarter {quarter + 1}");
                foreach (var subject in subjects)
                {
                    Console.WriteLine($"\n\t\t\tSubject: {subject.Name}");
                    subject.QuarterlyActivityScores[quarter] = GetScores(3, 100, "Activity Scores");
                    subject.QuarterlyQuizScores[quarter] = GetScores(2, 50, "Quiz Scores");
                    subject.QuarterlyExamScores[quarter] = GetSingleScore(50, "Exam Score");
                }

                if (quarter < 3)
                {
                    Console.Write("\n\t\t\tDo you want to input scores for Quarter " + (quarter + 2) + "? [Y/N]: ");
                    string input = Console.ReadLine();
                    if (!input.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                }
            }

            students.Add(new Student(name, gender, lrn, subjects));

            Console.WriteLine("\n\t\t\tStudent added successfully!\n");

            SaveData();
        }

        private List<Subject> InitializeSubjects()
        {
            return new List<Subject>
        {
            new Subject("Filipino", new List<int>[4], new List<int>[4], new int[4]),
            new Subject("English", new List<int>[4], new List<int>[4], new int[4]),
            new Subject("Mathematics", new List<int>[4], new List<int>[4], new int[4]),
            new Subject("Science", new List<int>[4], new List<int>[4], new int[4]),
            new Subject("Araling Panlipunan", new List<int>[4], new List<int>[4], new int[4]),
            new Subject("Edukasyon sa Pagpapakatao (ESP)", new List<int>[4], new List<int>[4], new int[4]),
            new Subject("MAPEH", new List<int>[4], new List<int>[4], new int[4])
             };
        }

        private List<int> GetScores(int count, int maxScore, string scoreType)
        {
            List<int> scores = new List<int>();
            Console.WriteLine($"\t\t\tEnter {scoreType} ({count} scores, max {maxScore} each):");
            for (int i = 0; i < count; i++)
            {
                int score;
                while (true)
                {
                    Console.Write($"\t\t\tScore {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= maxScore)
                    {
                        scores.Add(score);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\tInvalid score. Please enter a number between 0 and {maxScore}.");
                    }
                }
            }
            return scores;
        }

        private int GetSingleScore(int maxScore, string scoreType)
        {
            int score;
            Console.WriteLine($"\t\t\tEnter {scoreType} (max {maxScore}):");
            while (true)
            {
                Console.Write("\t\t\tScore: ");
                if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= maxScore)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\t\t\tInvalid score. Please enter a number between 0 and {maxScore}.");
                }
            }
            return score;
        }

        private void FindStudentByLRN()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.Write("\t\t\tEnter LRN: ");
            string lrn = Console.ReadLine();
            var student = students.Find(s => s.LRN == lrn);
            if (student != null)
            {
                student.DisplayDetails();
            }
            else
            {
                Console.WriteLine("\n\t\t\tStudent not found.\n");
            }

        }
        private void FindStudentByName()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.Write("\t\t\tEnter student name: ");
            string name = Console.ReadLine();
            var student = students.Find(s => s.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);

            if (student != null)
            {
                student.DisplayDetails();
            }
            else
            {
                Console.WriteLine("\n\t\t\tStudent not found.\n");
            }
        }
        private void DeleteStudent()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            ShowAllStudents();
            Console.Write("\t\t\tEnter the full name of the student to delete: ");
            string nameToDelete = Console.ReadLine()?.Trim();

            var studentToDelete = students.Find(s => s.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

            if (studentToDelete != null)
            {
                // Remove the student from the in-memory list
                students.Remove(studentToDelete);

                // Delete the associated folder from the disk
                string folderPath = GetStudentFolderPath(studentToDelete);
                if (Directory.Exists(folderPath))
                {
                    try
                    {
                        Directory.Delete(folderPath, true); // Use 'true' to delete the directory and its contents
                        Console.WriteLine("\n\t\t\tStudent and associated data deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n\t\t\tError deleting student data: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("\n\t\t\tNo associated data found for the student.");
                }

                // Save updated data
                SaveData();
            }
            else
            {
                Console.WriteLine("\n\t\t\tStudent not found.");
            }
        }

        private void UpdateStudent()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            ShowAllStudents();
            Console.Write("\t\t\tEnter the number of the student to update: ");
            string inputIndex = Console.ReadLine();

            if (int.TryParse(inputIndex, out int index) && index > 0 && index <= students.Count)
            {
                var sortedStudents = students.OrderBy(s => s.Name, StringComparer.OrdinalIgnoreCase).ToList();
                var student = sortedStudents[index - 1];

                // Store the old folder path before making any changes
                string oldFolderPath = GetStudentFolderPath(student);

                Thread.Sleep(800);
                Console.Clear();
                Console.Write("\n\n\n");

                while (true)
                {
                    Console.WriteLine("\n\t\t\tWhat would you like to update?");
                    Console.WriteLine("\t\t\t1. Personal Details");
                    Console.WriteLine("\t\t\t2. Scores");
                    Console.WriteLine("\t\t\t3. Cancel");
                    Console.Write("\t\t\tEnter your choice: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        UpdatePersonalDetails(student);
                        break;
                    }
                    else if (choice == "2")
                    {
                        UpdateScores(student);
                        break;
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("\t\t\tUpdate canceled.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\t\t\tInvalid choice. Please try again.");
                    }
                }

                // Delete the old folder after updates
                if (Directory.Exists(oldFolderPath))
                {
                    try
                    {
                        Directory.Delete(oldFolderPath, true); // Delete the old directory and its contents
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\t\t\tWarning: Unable to delete old data folder: {ex.Message}");
                    }
                }

                // Save the updated data
                SaveData();
                Console.WriteLine("\t\t\tStudent details updated successfully!\n");
            }
            else
            {
                Console.WriteLine("\n\t\t\tInvalid student number. Please enter a valid number from the list.\n");
            }
        }


        private void ShowAllStudents()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.WriteLine("\t\t\tList of Students:");

            if (!students.Any())
            {
                Console.WriteLine("\t\t\tNo students found.");
            }
            else
            {
                var sortedStudents = students.OrderBy(s => s.Name).ToList();
                int index = 1;

                foreach (var student in sortedStudents)
                {
                    Console.WriteLine($"\t\t\t{index}. {student.Name}");
                    index++;
                }
            }
            Console.WriteLine();
        }

        private void ShowGradeCard()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            ShowAllStudents();
            Console.Write("\t\t\tEnter the number of student to view grade card: ");
            string inputIndex = Console.ReadLine();

            if (int.TryParse(inputIndex, out int index) && index > 0 && index <= students.Count)
            {
                var sortedStudents = students.OrderBy(s => s.Name, StringComparer.OrdinalIgnoreCase).ToList();

                var student = sortedStudents[index - 1];

                student.DisplayGradeCard();
            }
            else
            {
                Console.WriteLine("\n\t\t\tInvalid student number. Please enter a valid number from the list.\n");
            }
        }

        private void UpdatePersonalDetails(Student student)
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.Write("\t\t\tEnter new name: ");
            student.Name = Console.ReadLine();

            while (true)
            {
                Console.Write("\t\t\tEnter new gender (Male/Female): ");
                student.Gender = Console.ReadLine();
                if (student.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ||
                    student.Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\t\t\tInvalid input. Please enter 'Male' or 'Female'.");
                }
            }

            while (true)
            {
                Console.Write("\t\t\tEnter LRN (Learner Reference Number): ");
                string newLRN = Console.ReadLine();

                if (newLRN.Length == 12 && long.TryParse(newLRN, out _))
                {
                    // Check if the LRN exists and belongs to a different student
                    if (students.Any(s => s.LRN == newLRN && s != student))
                    {
                        Console.WriteLine("\t\t\tThis LRN is already taken. Please enter a different LRN.");
                    }
                    else
                    {
                        student.LRN = newLRN;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\t\t\tInvalid LRN. Please enter exactly 12 numeric digits.");
                }
            }

            Console.WriteLine("\t\t\tPersonal details updated successfully!");
        }


        private void UpdateScores(Student student)
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");

            foreach (var subject in student.Subjects)
            {
                Console.WriteLine($"\n\t\t\tDo you want to update scores for {subject.Name}?");
                Console.WriteLine("\t\t\t1. All quarters");
                Console.WriteLine("\t\t\t2. Specific quarter");
                Console.WriteLine("\t\t\t3. Skip this subject");
                Console.Write("\t\t\tEnter your choice: ");
                string scoreChoice = Console.ReadLine();

                if (scoreChoice == "1")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"\n\t\t\tEnter new activity scores for {subject.Name} - Quarter {i + 1}: ");
                        subject.QuarterlyActivityScores[i] = GetScores(3, 100, "Activity Scores");

                        Console.WriteLine($"\n\t\t\tEnter new quiz scores for {subject.Name} - Quarter {i + 1}: ");
                        subject.QuarterlyQuizScores[i] = GetScores(2, 50, "Quiz Scores");

                        Console.WriteLine($"\n\t\t\tEnter new exam score for {subject.Name} - Quarter {i + 1}: ");
                        subject.QuarterlyExamScores[i] = GetSingleScore(50, "Exam Score");
                    }
                }
                else if (scoreChoice == "2")
                {
                    Console.Write("\t\t\tEnter quarter number (1-4) to update scores: ");
                    if (int.TryParse(Console.ReadLine(), out int quarter) && quarter >= 1 && quarter <= 4)
                    {
                        quarter--;

                        Console.WriteLine($"\n\t\t\tEnter new activity scores for {subject.Name} - Quarter {quarter + 1}: ");
                        subject.QuarterlyActivityScores[quarter] = GetScores(3, 100, "Activity Scores");

                        Console.WriteLine($"\n\t\t\tEnter new quiz scores for {subject.Name} - Quarter {quarter + 1}: ");
                        subject.QuarterlyQuizScores[quarter] = GetScores(2, 50, "Quiz Scores");

                        Console.WriteLine($"\n\t\t\tEnter new exam score for {subject.Name} - Quarter {quarter + 1}: ");
                        subject.QuarterlyExamScores[quarter] = GetSingleScore(50, "Exam Score");
                    }
                    else
                    {
                        Console.WriteLine("\t\t\tInvalid quarter number. Please enter a number between 1 and 4.");
                    }
                }
                else if (scoreChoice == "3")
                {
                    Console.WriteLine($"\t\t\tSkipping scores update for {subject.Name}.");
                }
                else
                {
                    Console.WriteLine("\t\t\tInvalid choice. Please try again.");
                }
            }

            Console.WriteLine("\t\t\tScores updated successfully!");
        }

    }

    public class Parent : User
    {
        private const string FilePath = @"C:\Users\LATITUDE\Documents\mama&papa\Yanna Da Great\Final Project\Students\Student.txt";
        private List<Student> students;
        public Parent(List<Student> studentList)
        {
            students = studentList;
        }
        public Parent()
        {
            LoadData();  
        }
        public override void ShowOptions()
        {
            bool ContinueProg = true;
            Thread.Sleep(800);
            Console.Clear();
            while (ContinueProg)
            {
                LoadData();
                Console.Write("\n\n\n");
                Console.WriteLine("\t\t\t1. Find details LRN");
                Console.WriteLine("\t\t\t2. Find details using name");
                Console.WriteLine("\t\t\t3. Show student's grade card");
                Console.WriteLine("\t\t\t4. Exit ");
                Console.Write("\t\t\tEnter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\n\t\t\tInvalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        FindStudentByLRN();
                        break;
                    case 2:
                        FindStudentByName();
                        break;
                    case 3:
                        ShowGradeCard();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("\n\t\t\tInvalid choice. Please try again.");
                        break;
                }
                string response;
                do
                {
                    Console.Write("\n\t\t\tReady to enter another choice? [Y/N]: ");
                    response = Console.ReadLine()?.Trim().ToUpper();

                    if (response != "Y" && response != "N")
                    {
                        Console.WriteLine("\n\t\t\tPick a valid choice: Y/N");
                    }
                }
                while (response != "Y" && response != "N");

                if (response == "N")
                {
                    ContinueProg = false;
                }

                Thread.Sleep(800);
                Console.Clear();
            }
        }
        private void LoadData()
        {
            students.Clear();

            string studentDataDirectory = @"C:\Users\LATITUDE\Documents\mama&papa\Yanna Da Great\Final Project\Students";

            foreach (var folderPath in Directory.GetDirectories(studentDataDirectory))
            {
                string studentFile = Path.Combine(folderPath, "student_data.txt");

                if (File.Exists(studentFile))
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(studentFile))
                        {
                            var student = new Student();
                            student.Name = reader.ReadLine()?.Split(":")[1]?.Trim();
                            student.Gender = reader.ReadLine()?.Split(":")[1]?.Trim();
                            student.LRN = reader.ReadLine()?.Split(":")[1]?.Trim();
                            reader.ReadLine(); 

                            student.Subjects = new List<Subject>();
                            List<string> subjectNames = new List<string>
                    {
                        "Filipino", "English", "Mathematics", "Science",
                        "Araling Panlipunan", "Edukasyon sa Pagpapakatao (ESP)", "MAPEH"
                    };

                            foreach (var subjectName in subjectNames)
                            {
                                List<int>[] defaultQuarterlyQuizScores = new List<int>[4];
                                List<int>[] defaultQuarterlyActivityScores = new List<int>[4];
                                int[] defaultQuarterlyExamScores = new int[4];

                                for (int i = 0; i < 4; i++)
                                {
                                    defaultQuarterlyQuizScores[i] = new List<int>();
                                    defaultQuarterlyActivityScores[i] = new List<int>();
                                }

                                Subject subject = new Subject(subjectName, defaultQuarterlyQuizScores, defaultQuarterlyActivityScores, defaultQuarterlyExamScores);
                                student.Subjects.Add(subject);
                            }

                            for (int quarter = 0; quarter < 4; quarter++)
                            {
                                string quarterLine = reader.ReadLine();

                                while (quarterLine != null && !quarterLine.Trim().StartsWith($"QUARTER {quarter + 1}", StringComparison.OrdinalIgnoreCase))
                                {
                                    quarterLine = reader.ReadLine(); 
                                }

                                if (quarterLine == null || !quarterLine.Trim().StartsWith($"QUARTER {quarter + 1}", StringComparison.OrdinalIgnoreCase))
                                {
                                    continue;
                                }

                                foreach (var subject in student.Subjects)
                                {
                                    try
                                    {

                                        string subjectNameLine = reader.ReadLine();
                                        if (subjectNameLine == null || !subjectNameLine.Contains(subject.Name))
                                        {
                                            continue;
                                        }

                                        var quizScoresLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyQuizScores[quarter] = !string.IsNullOrEmpty(quizScoresLine)
                                            ? quizScoresLine.Split(",").Select(score => int.TryParse(score.Trim(), out int result) ? result : 0).ToList()
                                            : new List<int>();

                                        var activityScoresLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyActivityScores[quarter] = !string.IsNullOrEmpty(activityScoresLine)
                                            ? activityScoresLine.Split(",").Select(score => int.TryParse(score.Trim(), out int result) ? result : 0).ToList()
                                            : new List<int>();

                                        var examScoreLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyExamScores[quarter] = !string.IsNullOrEmpty(examScoreLine) && int.TryParse(examScoreLine, out int examScore)
                                            ? examScore
                                            : 0;

                                        var gradeLine = reader.ReadLine()?.Split(":")[1]?.Trim();
                                        subject.QuarterlyGrades[quarter] = !string.IsNullOrEmpty(gradeLine) && double.TryParse(gradeLine, out double grade)
                                            ? grade
                                            : 0.0;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }

                            // Recalculate grades for all subjects after loading
                            foreach (var subject in student.Subjects)
                            {
                                subject.CalculateGrades();
                            }

                            students.Add(student);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                else
                {
                }
            }
        }

        private void FindStudentByLRN()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.Write("\t\t\tEnter LRN: ");
            string lrn = Console.ReadLine();
            var student = students.Find(s => s.LRN == lrn);
            if (student != null)
            {
                student.DisplayDetails();
            }
            else
            {
                Console.WriteLine("\n\t\t\tStudent not found.\n");
            }

        }

        private void FindStudentByName()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.Write("\t\t\tEnter student name: ");
            string name = Console.ReadLine();
            var student = students.Find(s => s.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);

            if (student != null)
            {
                student.DisplayDetails();
            }
            else
            {
                Console.WriteLine("\n\t\t\tStudent not found.\n");
            }
        }
        private void ShowGradeCard()
        {
            Thread.Sleep(800);
            Console.Clear();
            Console.Write("\n\n\n");
            Console.Write("\t\t\tEnter the student's name (First or Last Name): ");
            string name = Console.ReadLine();

            // Find the student by matching the input name with either first or last name (case-insensitive)
            var student = students.Find(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

            if (student != null)
            {
                student.DisplayGradeCard();
            }
            else
            {
                Console.WriteLine("\n\t\t\tStudent not found.\n");
            }
        }

    }

    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string LRN { get; set; }
        public List<Subject> Subjects { get; set; }
        public double GeneralAverage { get; set; }

        public Student()
        {
            Subjects = new List<Subject>();  
        }
        public Student(string name, string gender, string lrn, List<Subject> subjects)
        {
            Name = name;
            Gender = gender;
            LRN = lrn;
            Subjects = subjects;
        }

        public void DisplayDetails()
        {
            Console.Clear();
            Console.WriteLine($"\nName: {Name,-65}Gender: {Gender}");
            Console.WriteLine($"LRN: {LRN}\n");

            int totalFinalGrade = 0;
            int subjectCount = Subjects.Count;

            // Ensure grades are calculated before displaying them
            foreach (var subject in Subjects)
            {
                subject.CalculateGrades(); // Make sure grades are calculated first
            }

            for (int quarter = 0; quarter < 4; quarter++)
            {
                Console.WriteLine($"\nQUARTER {quarter + 1}\n");

                int quarterTotalGrade = 0; // To calculate the quarter grade after all subjects are displayed

                foreach (var subject in Subjects)
                {
                    Console.WriteLine($"  {subject.Name}");

                    // Display quiz scores for the quarter
                    Console.WriteLine("    Quiz Scores:");
                    for (int i = 0; i < subject.QuarterlyQuizScores[quarter].Count; i++)
                    {
                        Console.WriteLine($"      [{i + 1}] = {subject.QuarterlyQuizScores[quarter][i]}");
                    }

                    // Display activity scores for the quarter
                    Console.WriteLine("    Activity Scores:");
                    for (int i = 0; i < subject.QuarterlyActivityScores[quarter].Count; i++)
                    {
                        Console.WriteLine($"      [{i + 1}] = {subject.QuarterlyActivityScores[quarter][i]}");
                    }

                    // Display exam score for the quarter
                    Console.WriteLine($"    Exam Score: {subject.QuarterlyExamScores[quarter]}");

                    // Display calculated grade for the subject in this quarter as a whole number
                    Console.WriteLine($"    {subject.Name} Grade: {Math.Round(subject.QuarterlyGrades[quarter])}\n");

                    // Add the subject's grade to the quarter total grade for that quarter
                    quarterTotalGrade += (int)Math.Round(subject.QuarterlyGrades[quarter]);
                }

                // Calculate and display the quarter grade after all subjects are processed
                if (Subjects.Count > 0)
                {
                    int quarterGrade = quarterTotalGrade / Subjects.Count;
                    Console.WriteLine($"\n  GRADE (Quarter {quarter + 1}): {quarterGrade}\n");
                }

                // Ask to move to the next quarter after each quarter
                if (quarter < 3) // For Quarter 1 to 3, ask if they want to continue
                {
                    Console.WriteLine($"\nQuarter {quarter + 2}? [Y/N]: ");
                }
                else // For Quarter 4, ask if they want to input final grades
                {
                    Console.WriteLine("\nFinal Grades? [Y/N]: ");
                }

                string input = Console.ReadLine();
                if (input?.ToUpper() != "Y")
                {
                    break;
                }
            }

            // After all quarters, display final grades for each subject
            Console.WriteLine("\nFINAL GRADES:\n");

            foreach (var subject in Subjects)
            {
                Console.WriteLine($"  {subject.Name}: {Math.Round(subject.FinalGrade)}");
                totalFinalGrade += (int)Math.Round(subject.FinalGrade); // Accumulate final grade immediately
            }

            // Calculate General Average
            if (subjectCount > 0)
            {
                int generalAverage = totalFinalGrade / subjectCount;
                Console.WriteLine($"\nGeneral Average: {generalAverage}");
            }
        }


        public void DisplayGradeCard()
        {
            Thread.Sleep(800);
            Console.Clear();

            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine($"│ Name: {Name,-30} Gender:   {Gender,-15} LRN: {LRN,-15}                                     │");
            Console.WriteLine("├─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");

            Console.WriteLine("│ LEARNING AREAS                                │ Quarter 1 │ Quarter 2 │ Quarter 3 │ Quarter 4 │ Final Grade │ Remarks   │");
            Console.WriteLine("├───────────────────────────────────────────────┼───────────┼───────────┼───────────┼───────────┼─────────────┼───────────┤");

            foreach (var subject in Subjects)
            {
                if (subject == null)
                {
                    continue;
                }

                string remarks = subject.FinalGrade >= 75 ? "Passed" : "Failed";

                Console.Write($"│ {subject.Name,-45} │ {subject.QuarterlyGrades[0],9:F1} │ {subject.QuarterlyGrades[1],9:F1} │ {subject.QuarterlyGrades[2],9:F1} │ {subject.QuarterlyGrades[3],9:F1} │ {subject.FinalGrade,11:F1} │ ");

                // Set color for remarks based on pass/fail status
                Console.ForegroundColor = subject.FinalGrade >= 75 ? ConsoleColor.Green : ConsoleColor.Red;

                // Print the remarks with the appropriate color, all within the same line
                Console.Write($"{remarks,-9}");
               
                Console.ResetColor();

                Console.WriteLine(" |");
            }

            Console.WriteLine("└───────────────────────────────────────────────┴───────────┴───────────┴───────────┴───────────┴─────────────┴───────────┘");

     
            Console.WriteLine("\n Grading Scale:");
            Console.WriteLine(" ┌────────────────────────────┬─────────────────┬──────────────┐");
            Console.WriteLine(" │ Descriptions               │ Grading Scale   │ Remarks      │");
            Console.WriteLine(" ├────────────────────────────┼─────────────────┼──────────────┤");
            Console.WriteLine(" │ Outstanding                │    90 - 100     │ Passed       │");
            Console.WriteLine(" │ Very Satisfactory          │    85 - 89      │ Passed       │");
            Console.WriteLine(" │ Satisfactory               │    80 - 84      │ Passed       │");
            Console.WriteLine(" │ Fairly Satisfactory        │    75 - 79      │ Passed       │");
            Console.WriteLine(" │ Did Not Meet Expectations  │   Below 75      │ Failed       │");
            Console.WriteLine(" └────────────────────────────┴─────────────────┴──────────────┘");
            
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public List<int>[] QuarterlyQuizScores { get; set; }
        public List<int>[] QuarterlyActivityScores { get; set; }
        public int[] QuarterlyExamScores { get; set; }
        public double[] QuarterlyGrades { get; set; }
        public double FinalGrade { get; set; }

        private const double QUIZ_MAX = 100;
        private const double ACTIVITY_MAX = 300;
        private const double EXAM_MAX = 50;

        public Subject(string name, List<int>[] quarterlyQuizScores = null, List<int>[] quarterlyActivityScores = null, int[] quarterlyExamScores = null)
        {
            Name = name;
            QuarterlyQuizScores = InitializeQuarterlyData(quarterlyQuizScores);
            QuarterlyActivityScores = InitializeQuarterlyData(quarterlyActivityScores);
            QuarterlyExamScores = quarterlyExamScores?.Length == 4 ? quarterlyExamScores : new int[4];
            QuarterlyGrades = new double[4];

            CalculateGrades();
        }

        private List<int>[] InitializeQuarterlyData(List<int>[] input)
        {
            var result = new List<int>[4];
            for (int i = 0; i < 4; i++)
            {
                result[i] = input != null && input.Length > i && input[i] != null ? input[i] : new List<int>();
            }
            return result;
        }

        public void CalculateGrades()
        {
            double totalScore = 0;

            for (int i = 0; i < 4; i++)
            {
                double quizTotal = QuarterlyQuizScores[i].Sum();
                double activityTotal = QuarterlyActivityScores[i].Sum();
                double examScore = QuarterlyExamScores[i];

                double quizWeighted = (quizTotal / QUIZ_MAX) * 0.2;
                double activityWeighted = (activityTotal / ACTIVITY_MAX) * 0.3;
                double examWeighted = (examScore / EXAM_MAX) * 0.5;

                double quarterGrade = (quizWeighted + activityWeighted + examWeighted) * 100;
                QuarterlyGrades[i] = quarterGrade;
                totalScore += quarterGrade;
            }

            FinalGrade = totalScore / 4;
        }
    }
}