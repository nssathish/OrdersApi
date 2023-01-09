FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app
EXPOSE 80

RUN chmod 777 .

COPY /Orders.Api/out /app/
CMD dotnet build
CMD dotnet run