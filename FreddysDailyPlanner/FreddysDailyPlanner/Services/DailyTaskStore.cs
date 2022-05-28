using FreddysDailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreddysDailyPlanner.Services
{
    public class DailyTaskStore : IDataStore<DailyTask>
    {
        readonly List<DailyTask> DailyTasks;

        public DailyTaskStore()
        {
            DailyTasks = new List<DailyTask>()
            {
                //new DailyTask { Id = Guid.NewGuid().ToString(), Text = "First DailyTask", Description="This is an DailyTask description." },
                //new DailyTask { Id = Guid.NewGuid().ToString(), Text = "Second DailyTask", Description="This is an DailyTask description." },
                //new DailyTask { Id = Guid.NewGuid().ToString(), Text = "Third DailyTask", Description="This is an DailyTask description." },
                //new DailyTask { Id = Guid.NewGuid().ToString(), Text = "Fourth DailyTask", Description="This is an DailyTask description." },
                //new DailyTask { Id = Guid.NewGuid().ToString(), Text = "Fifth DailyTask", Description="This is an DailyTask description." },
                //new DailyTask { Id = Guid.NewGuid().ToString(), Text = "Sixth DailyTask", Description="This is an DailyTask description." }
            };
        }

        public async Task<bool> AddItemAsync(DailyTask DailyTask)
        {
            DailyTasks.Add(DailyTask);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(DailyTask DailyTask)
        {
            var oldDailyTask = DailyTasks.Where((DailyTask arg) => arg.Id == DailyTask.Id).FirstOrDefault();
            DailyTasks.Remove(oldDailyTask);
            DailyTasks.Add(DailyTask);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldDailyTask = DailyTasks.Where((DailyTask arg) => arg.Id == id).FirstOrDefault();
            DailyTasks.Remove(oldDailyTask);

            return await Task.FromResult(true);
        }

        public async Task<DailyTask> GetItemAsync(int id)
        {
            return await Task.FromResult(DailyTasks.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<DailyTask>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(DailyTasks);
        }
    }
}
