using System;

namespace _04_Klasser__PRR02_;

public class book
{

    private string name;
    private int pages;
    private int currentPage;

    public book(string n, int p)
    {
        name = n;
        pages = p;
        currentPage = 0;
    }

    public string GetName() => name;
    public int GetPages() => pages;
    public int GetCurrentPage() => currentPage;

    public void TurnPage()
    {
        if (currentPage < pages) currentPage++;
    }

}
