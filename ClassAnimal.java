import java.awt.Color;
import java.awt.Graphics;


public abstract class ClassAnimal implements IAnimals{	


	protected int posX;
	protected int posY;
	protected int countFood;
	protected int maxCountFood;
	protected int maxSpeed;
	protected Color colorBody;
	protected float weight;
	
	@Override
	public abstract void moveAnimal();
	
	@Override
	public abstract void drawAnimal(Graphics g);
	
	@Override
	public void setPosition(int x, int y) {
		posX = x;
		posY = y;
	}
	
	@Override
	public void hide(boolean hidely)
	{
		hidely = !hidely;
	}
	
	@Override
	public void eat(int count) {
		countFood++;
		if(countFood + count < maxCountFood) {
			countFood += count;
		}		
	} 
	
	public int getMaxCountFood() {
		return maxCountFood;
	}

	public int getMaxSpeed() {
		return maxSpeed;
	}

	public Color getColorBody() {
		return colorBody;
	}

	public float getWeight() {
		return weight;
	}	
}

/*
 * package labs;

import java.awt.Color;
import java.awt.Graphics;

public abstract class Ship implements ITransport {

	protected int posX;
	protected int posY;
	protected int countPassengers;
	protected int maxCountPassengers;
	protected int maxSpeed;
	protected Color colorBody;
	protected float weight;
	
	
	@Override
	public abstract void moveCar();

	@Override
	public abstract void drawCar(Graphics g);

	@Override
	public void setPosition(int x, int y) {
		this.posX = x;
		this.posY = y;
		
	}

	@Override
	public void loadPassenger(int count) {
		if(countPassengers + count < maxCountPassengers) {
			countPassengers += count;
		}		
	}

	@Override
	public int getPassenger() {
		int count = countPassengers;
		countPassengers = 0;
		return count;
	}

	public int getMaxCountPassengers() {
		return maxCountPassengers;
	}

	public int getMaxSpeed() {
		return maxSpeed;
	}

	public Color getColorBody() {
		return colorBody;
	}

	public float getWeight() {
		return weight;
	}
	
	

}

 */