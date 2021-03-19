using System.Text.Json;
using API.Helpers;
using Microsoft.AspNetCore.Http;

namespace API.Extensions
{
    static public class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse response, int currentPage,
         int itemsPerPage, int totalItems, int totalPages)
         {
             var paginationHeader = new PaginationHeaders(currentPage, itemsPerPage, totalItems, totalPages);
             
             var option = new JsonSerializerOptions
             {
                 PropertyNamingPolicy = JsonNamingPolicy.CamelCase
             };

             response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader, option));
             response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
         }
    }
}