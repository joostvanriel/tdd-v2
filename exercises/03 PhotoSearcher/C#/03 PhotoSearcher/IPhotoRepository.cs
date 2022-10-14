using System.Collections.Generic;

namespace _03_PhotoSearcher
{
    public interface IPhotoRepository
    {
        IList<IPhoto> GetPhotos();
        void DeletePhotos(IEnumerable<int> ids);
    }
}