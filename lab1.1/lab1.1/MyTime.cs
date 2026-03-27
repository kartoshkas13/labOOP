using System;

public class MyTime
{
    private int h;
    private int m;
    private int s;

    public MyTime()
    {
        h = 0;
        m = 0;
        s = 0;
    }

    public MyTime(int h, int m, int s)
    {
        if (h < 0 || h > 23)
            throw new ApplicationException("Години мають бути від 0 до 23");

        if (m < 0 || m > 59)
            throw new ApplicationException("Хвилини мають бути від 0 до 59");

        if (s < 0 || s > 59)
            throw new ApplicationException("Секунди мають бути від 0 до 59");

        this.h = h;
        this.m = m;
        this.s = s;
    }

    public void ChangeTime(int dh, int dm, int ds)
    {
        s += ds;
        m += dm + s / 60;
        s %= 60;

        h += dh + m / 60;
        m %= 60;

        h %= 24;

        if (s < 0)
        {
            s += 60;
            m--;
        }

        if (m < 0)
        {
            m += 60;
            h--;
        }

        if (h < 0)
        {
            h += 24;
        }
    }

    public string GetTime()
    {
        return h.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00");
    }
    public void SubtractTime(int dh, int dm, int ds)
    {
        s -= ds;
        m -= dm;

        if (s < 0)
        {
            s += 60;
            m--;
        }

        if (m < 0)
        {
            m += 60;
            h--;
        }

        h -= dh;

        if (h < 0)
        {
            h += 24;
        }
    }
}