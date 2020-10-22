using CodegymDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodegymBALInterface
{
    public interface ICourseService
    {
        IEnumerable<CourseView> Gets();
    }
}
