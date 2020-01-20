using System;
using System.Collections.Generic;
using ScrollViewApp.Helpers;

namespace ScrollViewApp.ViewModels
{
    public class MainViewModel : Observable
    {
        public List<TopicViewModel> Topics { get; set; }

        public MainViewModel()
        {
            Topics = new List<TopicViewModel>()
            {
                new TopicViewModel()
                {
                    Name = "Current affairs", Stories = new List<StoryViewModel>()
                    {
                        new StoryViewModel("A"),
                        new StoryViewModel("B"),
                        new StoryViewModel("C"),
                        new StoryViewModel("D")
                    }
                },
                new TopicViewModel()
                {
                    Name = "Jobs", Stories = new List<StoryViewModel>()
                    {
                        new StoryViewModel("P"),
                        new StoryViewModel("Q"),
                        new StoryViewModel("R"),
                        new StoryViewModel("S")
                    }
                },
                new TopicViewModel()
                {
                    Name = "Movies", Stories = new List<StoryViewModel>()
                    {
                        new StoryViewModel("1"),
                        new StoryViewModel("2"),
                        new StoryViewModel("3"),
                        new StoryViewModel("4"),
                        new StoryViewModel("5"),
                        new StoryViewModel("6"),
                        new StoryViewModel("7")
                    }
                },
                new TopicViewModel()
                {
                    Name = "Rental", Stories = new List<StoryViewModel>()
                    {
                        new StoryViewModel("P"),
                        new StoryViewModel("Q"),
                        new StoryViewModel("R"),
                        new StoryViewModel("S")
                    }
                },
                new TopicViewModel()
                {
                    Name = "News", Stories = new List<StoryViewModel>()
                    {
                        new StoryViewModel("I"),
                        new StoryViewModel("II")
                    }
                }
            };
        }
    }

    public class TopicViewModel
    {
        public string Name { get; set; }
        public List<StoryViewModel> Stories { get; set; }
    }

    public class StoryViewModel
    {
        public StoryViewModel(string name)
        {
            Name = name;
        }
        public StoryViewModel()
        {
        }
        public string Name { get; set; }
    }
}
