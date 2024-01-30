using Xunit;
using TP2;
namespace TP2Tests
{
  public class TestsGame
  {
/*    
    
    #region GetHighestDice
    [Fact]
    public void CanGetHighestDiceOnRandomHand ()
    {
      // Arrange
      int[] values = { 2, 12, 13, 22, 7 };

      // Act
      int highestDice = Game.GetHighestDice (values);

      // Assert
      Assert.Equal (Game.D5, highestDice);
    }
    [Fact]
    public void CanGetHighestDiceOnConstantHand ()
    {
      // Arrange
      int[] values = { 2, 2, 2, 2, 2 };

      // Act
      int highestDice = Game.GetHighestDice (values);

      // Assert
      Assert.Equal (Game.D3, highestDice);
    }
    #endregion // GetHighestDice

    #region HasPair
    [Fact]
    public void CantFindOnePairIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 19, 21 };

      // Act
      bool hasPair = Game.HasPair (values);

      // Assert
      Assert.False (hasPair);
    }
    [Fact]
    public void CanFindOnePairIfPresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 19, 18 };

      // Act
      bool hasPair = Game.HasPair (values);

      // Assert
      Assert.True (hasPair);
    }
    [Fact]
    public void CantFindOnePairIfThreeOfAKindPresent ()
    {
      // Arrange
      int[] values = { 3, 7, 9, 20, 21 };

      // Act
      bool hasPair = Game.HasPair (values);

      // Assert
      Assert.False (hasPair);
    }
    
    
    
    [Fact]
    public void CantFindOnePairIfFourOfAKindPresent ()
    {
      // Arrange
      int[] values = { 3,9, 16, 15, 21 };

      // Act
      bool hasPair = Game.HasPair (values);

      // Assert
      Assert.False (hasPair);
    }
    #endregion // HasPair

    #region HasTwoPairs
    [Fact]
    public void CantFindTwoPairsIfNonePresent ()
    {
      // Arrange
      int[] values = { 0, 7, 13, 20, 21 };

      // Act
      bool hasTwoPairs = Game.HasTwoPairs (values);

      // Assert
      Assert.False (hasTwoPairs);
    }
    [Fact]
    public void CantFindTwoPairsIfOnePairPresent ()
    {
      // Arrange
      int[] values = { 3, 7, 5, 21, 22 };

      // Act
      bool hasTwoPairs = Game.HasTwoPairs (values);

      // Assert
      Assert.False (hasTwoPairs);
    }
    [Fact]
    public void CanFindTwoPairsIfPresent ()
    {
      // Arrange
      int[] values = { 3, 15, 16, 4, 12 };

      // Act
      bool hasTwoPairs = Game.HasTwoPairs (values);

      // Assert
      Assert.True (hasTwoPairs);
    }
    [Fact]
    public void CantFindTwoPairsIfThreeOfAKindPresent ()
    {
      // Arrange
      int[] values = { 13, 15, 1, 14, 18 };

      // Act
      bool hasTwoPairs = Game.HasTwoPairs (values);

      // Assert
      Assert.False (hasTwoPairs);
    }
    [Fact]
    public void CantFindTwoPairsIfFourOfAKindPresent ()
    {
      // Arrange
      int[] values = { 13, 15, 1, 7, 18 };

      // Act
      bool hasTwoPairs = Game.HasTwoPairs (values);

      // Assert
      Assert.False (hasTwoPairs);
    }
    #endregion // HasTwoPairs

    #region HasThreeOfAKind
    [Fact]
    public void CantFindThreeOfAKindIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 24, 13 };

      // Act
      bool hasThreeOfAKind = Game.HasThreeOfAKind (values);

      // Assert
      Assert.False (hasThreeOfAKind);
    }
    [Fact]
    public void CantFindThreeOfAKindIfOnePairPresent ()
    {
      // Arrange
      int[] values = { 3, 9, 17, 19, 20 };

      // Act
      bool hasThreeOfAKind = Game.HasThreeOfAKind (values);

      // Assert
      Assert.False (hasThreeOfAKind);
    }
    [Fact]
    public void CantFindThreeOfAKindIfTwoPairsPresent ()
    {
      // Arrange
      int[] values = { 3, 9, 17, 19, 23 };

      // Act
      bool hasThreeOfAKind = Game.HasThreeOfAKind (values);

      // Assert
      Assert.False (hasThreeOfAKind);
    }
    [Fact]
    public void CanFindThreeOfAKindIfPresent ()
    {
      // Arrange
      int[] values = { 3, 9, 17, 19, 21 };

      // Act
      bool hasThreeOfAKind = Game.HasThreeOfAKind (values);

      // Assert
      Assert.True (hasThreeOfAKind);
    }
    [Fact]
    public void CantFindThreeOfAKindPairsIfFourOfAKindPresent ()
    {
      // Arrange
      int[] values = { 3, 9, 15, 19, 21 };

      // Act
      bool hasThreeOfAKind = Game.HasThreeOfAKind (values);

      // Assert
      Assert.False (hasThreeOfAKind);
    }
    #endregion // HasThreeOfAKind

    #region HasStraight
    [Fact]
    public void CantFindStraightIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 24, 13 };

      // Act
      bool hasStraight = Game.HasStraight (values);

      // Assert
      Assert.False (hasStraight);
    }

    [Fact]
    public void CantFindStraightIfNonePresentButSmallestDiceIs4MinusHighestDice ()
    {
      // Arrange
      int[] values = { 12, 6, 16, 24, 15 };

      // Act
      bool hasStraight = Game.HasStraight (values);

      // Assert
      Assert.False (hasStraight);
    }
    [Fact]
    public void CanFindStraightIfPresent ()
    {
      // Arrange
      int[] values = { 3, 10, 5, 19, 20 };

      // Act
      bool hasStraight = Game.HasStraight (values);

      // Assert
      Assert.True (hasStraight);
    }
    
    #endregion // HasStraight

    #region HasFlush
    [Fact]
    public void CantFindFlushIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 24, 13 };

      // Act
      bool hasFlush = Game.HasFlush (values);

      // Assert
      Assert.False (hasFlush);
    }
    [Fact]
    public void CanFindFlushIfPresent ()
    {
      // Arrange
      int[] values = { 6, 9, 11,7,10};

      // Act
      bool hasFlush = Game.HasFlush (values);

      // Assert
      Assert.True (hasFlush);
    }
    #endregion // HasFlush

    #region HasFullHouse
    [Fact]
    public void CantFindFullHouseIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 19, 21 };

      // Act
      bool hasFullHouse = Game.HasFullHouse (values);

      // Assert
      Assert.False (hasFullHouse);
    }
    [Fact]
    public void CanFindFullHouseIfPresent ()
    {
      // Arrange
      int[] values = { 3, 5, 11, 15, 17 };

      // Act
      bool hasFullHouse = Game.HasFullHouse (values);

      // Assert
      Assert.True (hasFullHouse);
    }
    #endregion // HasFullHouse

    #region HasFourOfAKind
    [Fact]
    public void CantFindFourOfAKindIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 19, 21 };

      // Act
      bool hasFourOfAKind = Game.HasFourOfAKind (values);

      // Assert
      Assert.False (hasFourOfAKind);
    }
    [Fact]
    public void CanFindFourOfAKindIfPresent ()
    {
      // Arrange
      int[] values = { 3, 10, 9, 15, 21 };

      // Act
      bool hasFourOfAKind = Game.HasFourOfAKind (values);

      // Assert
      Assert.True (hasFourOfAKind);
    }
    #endregion // HasFourOfAKind
    

    #region HasStraightFlush
    [Fact]
    public void CantFindStraighFlushIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 19, 21 };

      // Act
      bool hasStraightFlush = Game.HasStraightFlush (values);

      // Assert
      Assert.False (hasStraightFlush);
    }
    [Fact]
    public void CanFindStraightFlushIfPresent ()
    {
      // Arrange
      int[] values = { 13, 16, 15, 12, 14 };

      // Act
      bool hasStraightFlush = Game.HasStraightFlush (values);

      // Assert
      Assert.True (hasStraightFlush);
    }
    [Fact]
    public void CanFindStraightFlushIfRoyalFlushPresent ()
    {
      // Arrange
      int[] values = { 3, 4, 5, 1, 2 };

      // Act
      bool hasStraightFlush = Game.HasStraightFlush (values);

      // Assert
      Assert.True (hasStraightFlush);
    }
    #endregion // HasStraightFlush

    #region HasRoyalFlush
    [Fact]
    public void CantFindRoyalFlushIfNonePresent ()
    {
      // Arrange
      int[] values = { 3, 15, 17, 19, 21 };

      // Act
      bool hasRoyalFlush = Game.HasRoyalFlush (values);

      // Assert
      Assert.False (hasRoyalFlush);
    }
    [Fact]
    public void CantFindRoyalFlushIfStraightFlushPresent ()
    {
      // Arrange
      int[] values = { 3, 4, 0, 2, 1 };

      // Act
      bool hasRoyalFlush = Game.HasRoyalFlush (values);

      // Assert
      Assert.False (hasRoyalFlush);
    }
    [Fact]
    public void CanFindRoyalFlushIfPresent ()
    {
      // Arrange
      int[] values = { 3, 4, 5, 2, 1 }; 

      // Act
      bool hasRoyalFlush = Game.HasRoyalFlush (values);

      // Assert
      Assert.True (hasRoyalFlush);
    }
    #endregion // HasStraightFlush
    */
  }
}