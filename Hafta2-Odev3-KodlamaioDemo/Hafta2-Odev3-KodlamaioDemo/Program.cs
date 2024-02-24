using Business.Abstracts;
using Business.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concrete;
using Entities;

IGenericService<Category> _categoryService = new GenericService<Category>(new GenericDal<Category>(new List<Category>()));
IGenericService<Course> _courseService = new GenericService<Course>(new GenericDal<Course>(new List<Course>()));
IGenericService<Instructor> _instructorService = new GenericService<Instructor>(new GenericDal<Instructor>(new List<Instructor>()));

Console.WriteLine("\n************Category CRUD işlemler****************\n");

// Yeni kategori ekleme
await _categoryService.AddAsync(new Category { Id = 1, CategoryName = "Programlama" });
await _categoryService.AddAsync(new Category { Id = 2, CategoryName = "Frontend" });
await _categoryService.AddAsync(new Category { Id = 3, CategoryName = "Backend" });

// Tüm kategorileri alma ve yazdırma

var allCategories = _categoryService.GetAllAsync();
Console.WriteLine("Tüm kategoriler:");
foreach (var category in await allCategories)
{
    Console.WriteLine($"Id: {category.Id}, Name: {category.CategoryName}");
}

// Katgori güncelleme

var categoryToUpdate = _categoryService.GetById(1);
if (categoryToUpdate != null)
{
    categoryToUpdate.CategoryName = "Web Programlama";
    _categoryService.UpdateAsync(categoryToUpdate);
    Console.WriteLine("\nGüncellenmiş kategori:");
    Console.WriteLine($"Id: {categoryToUpdate.Id}, Name: {categoryToUpdate.CategoryName}");
}
else
{
    Console.WriteLine("\nGüncellenecek kategori bulunamadı.");
}

//Kategori silme

var categoryToDelete = _categoryService.GetById(3);
if (categoryToDelete != null)
{
    _categoryService.RemoveAsync(categoryToDelete);
    Console.WriteLine($"\nId'si {categoryToDelete.Id} olan kategori silindi");
}
else
{
    Console.WriteLine("\nSilinecek kategori bulunamadı.");
}

// Tüm kategorileri alma ve yazdırma

var allCategories1 = _categoryService.GetAllAsync();
Console.WriteLine("Tüm kategoriler:");
foreach (var category in await allCategories1)
{
    Console.WriteLine($"Id: {category.Id}, Name: {category.CategoryName}");
}

// Belirli bir kategoriye ait bilgileri alma ve yazdırma

var categoryById = _categoryService.GetById(2);
Console.WriteLine("\nId'si 2 olan kategori:");
Console.WriteLine($"Id: {categoryById.Id}, Name: {categoryById.CategoryName}");



Console.WriteLine("\n************Course CRUD işlemleri****************\n");

// Yeni Kurs ekleme

await _courseService.AddAsync(new Course { Id = 1, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", CompletionRate=90,InstructorId = 1, CategoryId = 1, });
await _courseService.AddAsync(new Course { Id = 2, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", CompletionRate=80, InstructorId = 1, CategoryId = 1, });
await _courseService.AddAsync(new Course { Id = 3, CourseName = "Programlamaya Giriş İçin Temel Kurs", CompletionRate=70,  InstructorId = 1, CategoryId = 1, });

// Tüm kursları alma ve yazdırma

var allCourses = _courseService.GetAllAsync();
Console.WriteLine("Tüm kurslar:");
foreach (var course in await allCourses)
{
    Console.WriteLine($"Id: {course.Id}, Name: {course.CourseName}");
}

// kurs güncelleme

var courseToUpdate = _courseService.GetById(3);
if (courseToUpdate != null)
{
    courseToUpdate.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
    _courseService.UpdateAsync(courseToUpdate);
    Console.WriteLine("\nGüncellenmiş kurs:");
    Console.WriteLine($"Id: {courseToUpdate.Id}, Name: {courseToUpdate.CourseName}");
}
else
{
    Console.WriteLine("\nGüncellenecek kurs bulunamadı.");
}

//kurs silme

var courseToDelete = _courseService.GetById(2);
if (courseToDelete != null)
{
    _courseService.RemoveAsync(courseToDelete);
    Console.WriteLine($"\nId'si {courseToDelete.Id} olan kurs silindi");
}
else
{
    Console.WriteLine("\nSilinecek kurs bulunamadı.");
}

// Tüm kursları alma ve yazdırma

var allCourses1 = _courseService.GetAllAsync();
Console.WriteLine("Tüm kurslar:");
foreach (var course in await allCourses1)
{
    Console.WriteLine($"Id: {course.Id}, Name: {course.CourseName}");
}

// Belirli bir kursa ait bilgileri alma ve yazdırma

var courseById = _courseService.GetById(3);
Console.WriteLine("\nId'si 3 olan kurs:");
Console.WriteLine($"Id: {courseById.Id}, Name: {courseById.CourseName}, Description: {courseById.Description}, CompletionRate: {courseById.CompletionRate}, CategoryId: {courseById.CategoryId}, InstructorId:{courseById.InstructorId}");


Console.WriteLine("\n************Instructor CRUD işlemler****************\n");

// Yeni Eğitmen ekleme
await _instructorService.AddAsync(new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" });
await _instructorService.AddAsync(new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı" });

// Tüm Eğitmenleri alma ve yazdırma

var allInstructors = _instructorService.GetAllAsync();
Console.WriteLine("Tüm Eğitmenler:");
foreach (var instructor in await allInstructors)
{
    Console.WriteLine($"Id: {instructor.Id}, Name: {instructor.FirstName}, LastName: {instructor.LastName}");
}

// Eğitmen güncelleme

var instructorToUpdate = _instructorService.GetById(2);
if (instructorToUpdate != null)
{
    instructorToUpdate.FirstName = "Enes";
    _instructorService.UpdateAsync(instructorToUpdate);
    Console.WriteLine("\nGüncellenmiş Eğitmen:");
    Console.WriteLine($"Id: {instructorToUpdate.Id}, Name: {instructorToUpdate.FirstName}, LastName: {instructorToUpdate.LastName}");
}
else
{
    Console.WriteLine("\nGüncellenecek Eğitmen bulunamadı.");
}

//Eğitmen silme

var instructorToDelete = _instructorService.GetById(2);
if (instructorToDelete != null)
{
    _instructorService.RemoveAsync(instructorToDelete);
    Console.WriteLine($"\nId'si {instructorToDelete.Id} olan Eğitmen silindi");
}
else
{
    Console.WriteLine("\nSilinecek Eğitmen bulunamadı.");
}

// Tüm Eğitmenleri alma ve yazdırma

var allInstructors2 = _instructorService.GetAllAsync();
Console.WriteLine("Tüm Eğitmenler:");
foreach (var instructor in await allInstructors2)
{
    Console.WriteLine($"Id: {instructor.Id}, Name: {instructor.FirstName}, LastName: {instructor.LastName}");
}

// Belirli bir Eğitmene ait bilgileri alma ve yazdırma

var instructorById = _instructorService.GetById(1);
Console.WriteLine("\nId'si 1 olan Eğitmen:");
Console.WriteLine($"Id: {instructorById.Id}, Name: {instructorById.FirstName}, LastName: {instructorById.LastName}");



