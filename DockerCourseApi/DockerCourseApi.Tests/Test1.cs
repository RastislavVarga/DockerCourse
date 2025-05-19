using System.Net;
using FluentAssertions;

namespace DockerCourseApi.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public async Task TestMethod1()
    {
        var httpClient = new CustomWebApplicationFactory().CreateClient();
        var response = await httpClient.GetAsync("/podcasts");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}