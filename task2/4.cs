void CheckSecurity(string[] people)
{
  bool found = false;
  for (int i = 0; i < people.Length; i++)
  {
    if (!found)
    {
      if (people[i].Equals("Don")) {
        SendAlert();
        found = true;
      }
      if (people[i].Equals("John")) {
        SendAlert();
        found = true;
      }
    }
  }
}