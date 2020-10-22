using CodegymDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodegymDALInterface
{
    public interface ICourseRepository
    {
        IEnumerable<CourseView> Gets();
    }
}
