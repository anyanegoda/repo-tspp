class Employee {
boolean isPriviliged() { }
void assignCar() { }
}
class Manager {
public Manager (String name, String id, int grade) {
super (name, id);
_grade = grade;
if (isPriviliged())
assignCar(); //��� ��������� ��� ���������
}
boolean isPriviliged(){
return _grade > 4;
}
}