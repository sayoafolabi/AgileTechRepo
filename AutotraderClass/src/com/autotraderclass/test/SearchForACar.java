package com.autotraderclass.test;

import java.util.List;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.support.ui.Select;

public class SearchForACar 
{
	private WebDriver driver;
	private WebElement logo;
	private WebElement postcode;
	private WebElement distance;
	private WebElement make;
	private WebElement submitButton;
	private List<WebElement> searchResultTitle;
	private List<WebElement> searchResultLink;
	
	
	@Before
	public void setUp()
	{
		//driver = new FirefoxDriver();
		System.setProperty("webdriver.chrome.driver", "./lib/chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();
	}
	
	
	@After
	public void tearDown()
	{
		driver.manage().deleteAllCookies();
		driver.close();
		driver.quit();
	}
	
	
	@Test
	public void SearchForACarTest() throws Exception
	{
		driver.navigate().to("http://www.autotrader.co.uk/");
		
		//System Test - Verifying that logo is displayed. UAT - Confirming that the website is displayed
		logo = driver.findElement(By.className("site-header__logo"));
		Assert.assertTrue("Logo is not displayed", logo.isDisplayed());
		
		//Enter postcode
		postcode = driver.findElement(By.id("postcode"));
		postcode.clear();
		postcode.sendKeys("OL9 8LE");
		
		//Select distance
		distance = driver.findElement(By.id("radius"));
		
		Select distanceDropdown = new Select(distance);
		distanceDropdown.selectByValue("60");
		
		//Enter car make
		make = driver.findElement(By.id("searchVehiclesMake"));
		
		Select carMake = new Select(make);
		carMake.selectByValue("audi");
		
		//Submit car search criteria
		submitButton = driver.findElement(By.id("search"));
		submitButton.click();
		
		Thread.sleep(5000);
		
		//Verifying that search result is displayed
		searchResultTitle = driver.findElements(By.className("search-result__title"));
		Assert.assertTrue("Search Result Titles were not displayed", searchResultTitle.size()>0);
		
		searchResultLink = driver.findElements(By.className("gui-test-search-result-link"));
		Assert.assertTrue("Search Result Links were not displayed", searchResultLink.size()>0);
		
		
	}
	
	
	
	
	
}
