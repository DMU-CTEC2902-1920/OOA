using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GamesReviewWebsite;
using GamesReviewWebsite.Controllers;
using GamesReviewWebsite.Models;

namespace GamesReviewWebsite.Tests.Controllers
{
    [TestClass]
    public class GamesCollectionTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            GamesCollectionsController controller = new GamesCollectionsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GameName()
        {
            GamesCollectionsController controller = new GamesCollectionsController();
            ViewResult viewResult = controller.Games();
            GameReview result = viewResult.Model as GameReview;
            Assert.AreEqual("Call of Duty", result.GameName);
        }

        [TestMethod]
        public void GameIsOver18()
        {

            GamesCollectionsController controller = new GamesCollectionsController();
             
            ViewResult result = controller.Games();
             
            Assert.AreEqual("Only those aged 18 and over may play this game ", result.ViewBag.SubTitle);
        }

        [TestMethod]
        public void GameAgeRatingIsUnder18()
        {

            GameReview model = new GameReview();
            model.GameName = "Test Game 1";
            model.GameDescription = "Description of Test Game 1";
            model.GameAgeRating = 12;

            GamesCollectionsController controller = new GamesCollectionsController(model);

            ViewResult result = controller.Games();
            Assert.AreEqual("This game is suitable for those under 18 to play ", result.ViewBag.SubTitle);

        }
    }

    
}
