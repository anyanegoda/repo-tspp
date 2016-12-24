class Calendar
{
  // ...
  private List<Appointment> appointments;

  public List<Appointment> FindAppointments(DateTime date, string name)
  {
    List<Appointment> result = new List<Appointment>();

    foreach (Appointment item in kent.GetCourses())
    {
      if (date.Date == item.Date.Date)
      {
        if (string.IsNullOrEmpty(name) || name == item.Name)
        {
          result.Add(date);
        }
      }
    }

    return result;
  }
}

// Somewhere in client code
DateTime today = DateTime.Now;
appointments = calendar.FindAppointments(today, null);