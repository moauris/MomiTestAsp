using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(this IApplicationBuilder app)
        {
            var context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<BXSimDbContext>();

            if (!context.QuizScenarios.Any())
            {
                context.QuizScenarios.AddRange(new QuizScenario[] {
                    new QuizScenario
                    {
                        ScenarioPartial = "Render partial test1",
                        Quizzes = new Quiz[]
                        {
                            new Quiz {Statement = "quiz1", Answers = new string[] {"correct1", "correct2"}, Options = new string[] {"wrong1","wrong2"}},
                            new Quiz {Statement = "quiz2", Answers = new string[] {"correct1", "correct2"}, Options = new string[] {"wrong2","wrong3"}}
                        }
                    },
                    new QuizScenario
                    {
                        ScenarioPartial = "Render partial test2",
                        Quizzes = new Quiz[]
                        {
                            new Quiz {Statement = "quiz1", Answers = new string[] {"correct1", "correct2"}, Options = new string[] {"wrong1","wrong2"}},
                            new Quiz {Statement = "quiz2", Answers = new string[] {"correct1", "correct2"}, Options = new string[] {"wrong2","wrong3"}}
                        }
                    }





                    });
                context.SaveChanges();

            }
        }
    }
}
