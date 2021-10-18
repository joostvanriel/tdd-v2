using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_PhotoSearcher
{
    public class PhotoDeleter
    {
        private IPhotoRepository photoRepository;

        public PhotoDeleter(IPhotoRepository photoRepository)
        {
            this.photoRepository = photoRepository;
        }

        public void DeletePhotos(FuzzyDate fuzzyDate)
        {
            var idsToDelete = photoRepository.GetPhotos()
                .Where(photo => fuzzyDate.Contains(photo.Date))
                .Select(photo => photo.Id);

            photoRepository.DeletePhotos(idsToDelete);
        }

        public void DeletePhotos(FuzzyDate fuzzyDate, Color color, ContentType? contentType)
        {
            var idsToDelete = photoRepository.GetPhotos()
                .Where(photo => fuzzyDate.Contains(photo.Date) && photo.Color.Equals(color) && photo.ContentType == contentType)
                .Select(photo => photo.Id);

            photoRepository.DeletePhotos(idsToDelete);
        }

    }
}
