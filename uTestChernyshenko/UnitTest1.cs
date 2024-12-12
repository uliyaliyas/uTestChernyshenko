namespace uTestChernyshenko
{
    public class StringCalculatorTests
    {
        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            // Arrange
            string numbers = "";

            // Act
            int result = StringCalculatorKata.Add(numbers);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_SingleNumber_ReturnsNumber()
        {
            // Arrange
            string numbers = "5";

            // Act
            int result = StringCalculatorKata.Add(numbers);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
