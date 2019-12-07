-- PL/SQL Linear Regression Calculation Script --
-- @authors: Kerri McMahon, Wyatt Montana --
DECLARE
type num_array is varray(120) of number;

--Upper case declarations --
Y num_array;
X1 num_array;
X2 num_array;

sumY number;
sumX1 number;
sumX2 number;

sumYsquared number;
sumX1squared number;
sumX2squared number;

sumX1Y number;
sumX2Y number;
sumX1X2 number;

--Lower case declarations --
Lsumysquared number;
Lsumx1squared number;
Lsumx2squared number;

Lsumx1y number;
Lsumx2y number;
Lsumx1x2 number;

b1 number;
b2 number;

a number;

avgY number;
avgX1 number;
avgX2 number;






cursor c1 is select ticket_price, days_until_flight, seats_available from flight_data;



-- to determine the cost based on X1 - days till flight and X2 - number of seats available
dtf integer;
nsa integer;
price number;





BEGIN
open c1;
fetch c1 bulk collect into Y,X1,X2;
close c1;

-- Step 1: sum Y
sumY :=0;
for indx in Y.first..Y.last loop
sumY := sumY + Y(indx);
end loop;
--dbms_output.put_line(sumY);

-- Step 2: sumX1
sumX1 :=0;
for indx in X1.first..X1.last loop
sumX1 := sumX1 + X1(indx);
end loop;
--dbms_output.put_line(sumX1);


-- Step 3: sumX2
sumX2 :=0;
for indx in X2.first..X2.last loop
sumX2 := sumX2 + X2(indx);
end loop;
--dbms_output.put_line(sumX2);

-- Step 4: sumY^2 .. Squaring each value in Y first, then summing
sumYsquared :=0;
for indx in Y.first..Y.last loop
sumYsquared := sumYsquared + (Y(indx) * Y(indx));
end loop;
--dbms_output.put_line(sumYsquared);


--Step 5: sumX1squared .. Squaring each value in X1 first, then summing
sumX1squared :=0;
for indx in X1.first..X1.last loop
sumX1squared := sumX1squared + (X1(indx) * X1(indx));
end loop;
--dbms_output.put_line(sumX1squared);

-- Step 6: sumX2squared .. Squaring each value in X2 first, then summing
sumX2squared :=0;
for indx in X2.first..X2.last loop
sumX2squared := sumX2squared + (X2(indx) * X2(indx));
end loop;
--dbms_output.put_line(sumX2squared);


-- Step 7: sumX1Y .. multiplying two terms first, then summing--
sumX1Y :=0;
for indx in Y.first..Y.last loop
sumX1Y := sumX1Y + (X1(indx) * Y(indx));
end loop;
--dbms_output.put_line(sumX1Y);


--Step 8: sum X2Y .. multiplying two terms first, then summing
sumX2Y :=0;
for indx in Y.first..Y.last loop
sumX2Y := sumX2Y + (X2(indx) * Y(indx));
end loop;
--dbms_output.put_line(sumX2Y);

-- Step 9: sumX1X2 .. multiplying two terms first, then summing
sumX1X2 :=0;
for indx in X2.first..X2.last loop
sumX1X2 := sumX1X2 + (X1(indx) * X2(indx));
end loop;
--dbms_output.put_line(sumX1X2);


-- LOWER CASE -- Note: N is 112

--Step 10 - Lsumysquared
Lsumysquared := sumYsquared - ((sumY * sumY)/112);
--dbms_output.put_line(Lsumysquared);


-- Step 11: Lsumx1squared
Lsumx1squared := sumX1squared - ((sumX1 * sumX1)/112);
--dbms_output.put_line(Lsumx1squared);


-- Step 12: Lsumx2squared
Lsumx2squared := sumX2squared - ((sumX2 * sumX2)/112);
--dbms_output.put_line(Lsumx2squared);

-- Step 13: Lsumx1y
Lsumx1y := sumX1Y - ((sumX1 * sumY)/112);
--dbms_output.put_line(Lsumx1y); -- This returns a negative number .. double check

--Step 14: Lsumx2y
Lsumx2y := sumX2Y - ((sumX2 * sumY)/112);
--dbms_output.put_line(Lsumx2y); -- Also outputs a negative .. double check

--Step 15: Lsumx1x2
Lsumx1x2 := sumX1X2 - ((sumX1*sumX2)/112);
--dbms_output.put_line(Lsumx1x2);


--b1 and b2 ...oh god--


b1 := ((Lsumx2squared * Lsumx1y) - (Lsumx1x2 * Lsumx2y))/((Lsumx1squared * Lsumx2squared) - (Lsumx1x2 * Lsumx1x2));
--dbms_output.put_line(b1);

b2 := ((Lsumx1squared * Lsumx2y) - (Lsumx1x2 * Lsumx1y))/((Lsumx1squared * Lsumx2squared) - (Lsumx1x2 * Lsumx1x2));
--dbms_output.put_line(b2);

--oh we have to have the averages of Y, X1 and X2 .. hold up --

avgY := sumY/112;
avgX1 := sumX1 / 112;
avgX2 := sumX2/112;

a := avgY - (b1 * avgX1) - (b2 * avgX2);
--dbms_output.put_line(a);


--final equation --
--X1 - days till flight and X2 - number of seats available
dbms_output.put_line( 'y = ('|| a || ') + (' || b1 || ') X1 ' || ' + (' || b2 || ') X2');

-- Things to do:

-- +We have to load b1, b2 and a into the COEF table. this will enable us to easily 
--get these variables into VB and do calculations there. Perhaps that is why she suggested
-- a COEF table.
-- +Let's scratch the current attributes in that table because she meant b1, b2 and a 
--when she referred t or coefficients.
-- +We get a, b1 and b2 into VB, do calculations there 


END;

