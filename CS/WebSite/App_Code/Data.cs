#region Using
using System;
using System.Collections;
using System.Collections.Generic;
#endregion

class MasterItem {
	string m_firstName, m_lastName;

	public MasterItem(string first, string last) {
		this.m_firstName = first;
		this.m_lastName = last;
	}

	public string FirstName {
		get { return m_firstName; }
		set { m_firstName = value; } 
	}
	public string LastName {
		get { return m_lastName; }
		set { m_lastName = value; } 
	}
}

class DetailItem {
	string m_firstNameKey, m_lastNameKey;
	int m_orderId;
	string m_customerName;

	public DetailItem(string firstNameKey, string lastNameKey, int orderId, string customerName) {
		this.m_firstNameKey = firstNameKey;
		this.m_lastNameKey = lastNameKey;
		this.m_orderId = orderId;
		this.m_customerName = customerName;
	}

	public string FirstNameKey { 
		get { return m_firstNameKey; }
		set { m_firstNameKey = value; }
	}
	public string LastNameKey {
		get { return m_lastNameKey; }
		set { m_lastNameKey = value; }
	}
	public int OrderId {
		get { return m_orderId; }
		set { m_orderId = value; }
	}
	public string CustomerName {
		get { return m_customerName; }
		set { m_customerName = value; }
	}
}

public static class DataProvider {
	public static IEnumerable CreateMasterData() {
		List<MasterItem> list = new List<MasterItem>();
		list.Add(new MasterItem("Nancy", "Davolio"));
		list.Add(new MasterItem("Andrew", "Fuller"));
		return list;
	}
	public static IEnumerable CreateDetailData(string firstName, string lastName) {
		List<DetailItem> list = new List<DetailItem>();
		switch(firstName + lastName) {
			case "NancyDavolio":
				list.Add(new DetailItem(firstName, lastName, 10258, "Ernst Handel"));
				list.Add(new DetailItem(firstName, lastName, 10270, "Wartian Herkku"));
				list.Add(new DetailItem(firstName, lastName, 10275, "Magazzini Alimentari Riuniti"));
				break;
			case "AndrewFuller":
				list.Add(new DetailItem(firstName, lastName, 10265, "Blondel père et fils"));
				list.Add(new DetailItem(firstName, lastName, 10277, "Morgenstern Gesundkost"));
				list.Add(new DetailItem(firstName, lastName, 10280,	"Berglunds snabbköp"));
				break;
		}
		return list;
	}
}