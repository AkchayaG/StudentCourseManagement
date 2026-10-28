
using StudentCourseManagement.Models;
using StudentCourseManagement.Repository;

namespace StudentCourseManagement.Services;

public class CourseService
{
    private readonly CourseRepository _repository;

    public CourseService(CourseRepository repository)
    {
        _repository = repository;
    }

    public async Task AddCourseAsync(Course course)
    {
        if (course == null)
            throw new ArgumentNullException(nameof(course));

        if (string.IsNullOrWhiteSpace(course.CourseName))
            throw new ArgumentException("Course name is required.");

        course.CourseName = course.CourseName.Trim();

        if (course.DurationMonths <= 0)
            throw new ArgumentException("Course duration must be greater than zero.");

        if (course.Fee < 0)
            throw new ArgumentException("Course fee cannot be negative.");

        await _repository.AddCourseAsync(course);
    }

    public async Task<List<Course>> GetAllCoursesAsync()
    {
        return await _repository.GetAllCoursesAsync();
    }

    public async Task<Course?> GetCourseByIdAsync(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Course ID must be greater than zero.");

        return await _repository.GetCourseByIdAsync(id);
    }
}
