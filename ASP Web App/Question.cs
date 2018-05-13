using System.Collections.Generic;

namespace ASP_Web_App
{
    class Reader
    {
        public List<string> SeeQuestions(Test test)
        {
            var result = new List<string>();
            var iterator = test.CreateNumerator();
            while (iterator.HasNext())
            {
                Question question = iterator.Next();
                result.Add(question.Name);
            }

            return result;
        }
    }

    interface IQuestionIterator
    {
        bool HasNext();
        Question Next();
    }
    interface IQuestionNumerable
    {
        IQuestionIterator CreateNumerator();
        int Count { get; }
        Question this[int index] { get; }
    }
    class Question
    {
        public string Name { get; set; }
    }

    class Test : IQuestionNumerable
    {
        private Question[] questions;
        public Test()
        {
            questions = new Question[]
            {
            new Question{Name="What is class?"},
            new Question{Name="What is SOA?"},
            new Question{Name="What is Web Service?"}
            };
        }
        public int Count
        {
            get { return questions.Length; }
        }

        public Question this[int index]
        {
            get { return questions[index]; }
        }
        public IQuestionIterator CreateNumerator()
        {
            return new TestNumerator(this);
        }
    }
    class TestNumerator : IQuestionIterator
    {
        IQuestionNumerable aggregate;
        int index = 0;
        public TestNumerator(IQuestionNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Question Next()
        {
            return aggregate[index++];
        }
    }
}