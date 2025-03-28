namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_Patino()
	{
		Assert.AreEqual(2, Program.Subtract("4", "2"));
		Assert.AreEqual(6, Program.Subtract("10", "3"));
		Assert.AreEqual(-2, Program.Subtract("5", "7"));
	}

	[TestMethod]
	public void Subtract_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}
}

[TestClass]
public class Multiply
{
	[TestMethod]
	public void Multiply_Valid_Patino()
	{
		Assert.AreEqual(8, Program.Multiply("4", "2"));
		Assert.AreEqual(30, Program.Multiply("10", "3"));
		Assert.AreEqual(35, Program.Multiply("5", "7"));
	}
}


