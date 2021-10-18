using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace _03_PhotoSearcher.Tests
{
    [TestClass]
    public class PhotoDeleterTest
    {
        private Mock<IPhotoRepository> photoRepositoryMock;
        private PhotoDeleter photoDeleter;

        [TestInitialize]
        public void SetUp()
        {
            photoRepositoryMock = new Mock<IPhotoRepository>();
            photoDeleter = new PhotoDeleter(photoRepositoryMock.Object);
        }

        [TestMethod]
        public void DeletePhotosShouldDeletePhotoInsideFuzzyDate()
        {
            // arrange
            var photos = new List<IPhoto>
            {
                new DummyPhoto {Id = 1, Date = new DateTime(2019, 1, 1)}
            };
            photoRepositoryMock.Setup(r => r.GetPhotos()).Returns(photos);

            // act
            photoDeleter.DeletePhotos(new FuzzyDate(FuzzyDate.Quarters.Q1, 2019));

            // assert
            photoRepositoryMock.Verify(r => r.DeletePhotos(new[] {1}), Times.Exactly(1));
        }

        [TestMethod]
        public void DeletePhotosShouldNotDeletePhotoOutsideFuzzyDate()
        {
            // arrange
            var photos = new List<IPhoto>
            {
                new DummyPhoto {Id = 1, Date = new DateTime(2019, 4, 1)}
            };
            photoRepositoryMock.Setup(r => r.GetPhotos()).Returns(photos);

            // act
            photoDeleter.DeletePhotos(new FuzzyDate(FuzzyDate.Quarters.Q1, 2019));

            // assert
            photoRepositoryMock.Verify(r => r.DeletePhotos(new[] { 1 }), Times.Never);
        }

        [TestMethod]
        public void DeletePhotosShouldDeletePhotosWithMatchingDateColorAndContentType()
        {
            // arrange
            SetUpPhotoRepositoryWithSinglePhoto(new Color(255, 255, 0), ContentType.Cars, new DateTime(2019, 1, 1));

            // act
            photoDeleter.DeletePhotos(new FuzzyDate(FuzzyDate.Quarters.Q1, 2019), new Color(255, 255, 0), ContentType.Cars);

            // assert
            photoRepositoryMock.Verify(r => r.DeletePhotos(new[] { 1 }), Times.Exactly(1));
        }

        [TestMethod]
        public void DeletePhotosShouldNotDeletePhotosWithOnlyUnmatchingDate()
        {
            // arrange
            SetUpPhotoRepositoryWithSinglePhoto(new Color(255, 255, 0), ContentType.Cars, new DateTime(2019, 4, 1));

            // act
            photoDeleter.DeletePhotos(new FuzzyDate(FuzzyDate.Quarters.Q1, 2019), new Color(255, 255, 0), ContentType.Cars);

            // assert
            photoRepositoryMock.Verify(r => r.DeletePhotos(new[] { 1 }), Times.Never);
        }

        [TestMethod]
        public void DeletePhotosShouldNotDeletePhotosWithOnlyUnmatchingColor()
        {
            // arrange
            SetUpPhotoRepositoryWithSinglePhoto(new Color(0, 0, 0), ContentType.Cars, new DateTime(2019, 1, 1));

            // act
            photoDeleter.DeletePhotos(new FuzzyDate(FuzzyDate.Quarters.Q1, 2019), new Color(255, 255, 0), ContentType.Cars);

            // assert
            photoRepositoryMock.Verify(r => r.DeletePhotos(new[] { 1 }), Times.Never);
        }

        [TestMethod]
        public void DeletePhotosShouldNotDeletePhotosWithOnlyUnmatchingContentType()
        {
            // arrange
            SetUpPhotoRepositoryWithSinglePhoto(new Color(255, 255, 0), ContentType.Flowers, new DateTime(2019, 1, 1));

            // act
            photoDeleter.DeletePhotos(new FuzzyDate(FuzzyDate.Quarters.Q1, 2019), new Color(255, 255, 0), ContentType.Cars);

            // assert
            photoRepositoryMock.Verify(r => r.DeletePhotos(new[] { 1 }), Times.Never);
        }


        private void SetUpPhotoRepositoryWithSinglePhoto(Color color, ContentType contentType, DateTime dateTime)
        {
            var photos = new List<IPhoto>
            {
                new DummyPhoto
                    {Id = 1, Color = color, ContentType = contentType, Date = dateTime}
            };
            photoRepositoryMock.Setup(r => r.GetPhotos()).Returns(photos);
        }
    }
}
