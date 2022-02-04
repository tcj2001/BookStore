/////////////////////////////////////
// generated JobService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class JobService : IJobService
    {
        private readonly IRepositoryManager _repositoryManager;

        public JobService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<Job> entities, string Message)> FindJob(Expression<Func<Job, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.JobRepository.Find(expression);
            return (items, "Job records retrieved");
        }

        public async Task<(IEnumerable<Job> entities, string Message)> GetAllJob(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.JobRepository.GetAll();
            return (items, "Job records retrieved");
        }

        public async Task<(Job? entity, string Message)> GetJobById(short JobId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.JobRepository.GetById(JobId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Job", JobId.ToString());
            }
            return (item, "Job record retrieved");
        }

        public async Task<string> AddJob(Job entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.JobRepository.GetById(entity.JobId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("Job", entity.JobId.ToString());
                }
                else
                {
                    await _repositoryManager.JobRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Job record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveJob(short JobId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.JobRepository.GetById(JobId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Job", JobId.ToString());
            }
            else
            {
                _repositoryManager.JobRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "Job record deleted";
            }
        }

        public async Task<string> UpdateJob(Job entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.JobRepository.GetById(entity.JobId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("Job", entity.JobId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.JobRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Job record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
