void CheckSecurity(string[] people)
{
  for (int i = 0; i < people.Length; i++)
  {
    if (people[i].Equals("Don")) {
      SendAlert();
      break;
    }
    if (people[i].Equals("John")) {
      SendAlert();
      break;
    }
  }
}