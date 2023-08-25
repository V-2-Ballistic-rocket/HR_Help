using HR_Help.Models;
using HR_Help.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IApplicantService, ApplicantService>();

var app = builder.Build();

app.UseSwagger();

app.MapGet("/", () => "Hello World!");

app.MapPost("/create",
    (Applicant applicant, IApplicantService service) => Create(applicant, service));

app.MapGet("/get",
    (int id, IApplicantService service) => Get(id, service));

app.MapGet("/list",
    (IApplicantService service) => List(service));

app.MapPut("/update",
    (Applicant newApplicant, IApplicantService service) => Update(newApplicant, service));

app.MapDelete("/delete",
    (int id, IApplicantService service) => Delete(id, service));

IResult Create(Applicant applicant, IApplicantService service)
{
    var result = service.Create(applicant);
    return Results.Ok(result);
}

IResult Get(int id, IApplicantService service)
{
    var applicant = service.Get(id);

    if (applicant == null) return Results.NotFound("Applicant not found");
    
    return Results.Ok(applicant);
}

IResult List(IApplicantService service)
{
    var result = service.List();
    return Results.Ok(result);
}

IResult Update(Applicant newApplicant, IApplicantService service)
{
    var result = service.Update(newApplicant);

    if (result is null) return Results.NotFound("Applicant not found");

    return Results.Ok(result);
}

IResult Delete(int id, IApplicantService service)
{
    var result = service.Delete(id);
    
    if (!result) return Results.BadRequest("Something went wrong");
    
    return Results.Ok(result);
}

app.UseSwaggerUI();

app.Run();
