using Microsoft.VisualBasic;
using Streamish.Models;
using System;
using System.Collections.Generic;

namespace Streamish.Repositories
{
    public interface IVideoRepository
    {
        void Add(Video video);
        void Delete(int id);
        List<Video> GetAll();
        Video GetById(int id);

        Video GetVideoByIdWithComments(int id);
        void Update(Video video);
        List<Video> GetAllWithComments();
        List<Video> Search(string criterion, bool sortDescending);
        List<Video> SearchByDate(DateTime Since);
    }
}