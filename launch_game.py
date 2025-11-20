import subprocess
import os

def launch_game():
    """
    Launches the GeoMente game executable.
    """
    exe_path = os.path.join("GeoMente", "bin", "Debug", "GeoMente.exe")
    
    if not os.path.exists(exe_path):
        print(f"Error: Executable not found at '{exe_path}'")
        return

    print(f"Launching game from: {exe_path}")
    try:
        subprocess.run([exe_path], check=True)
    except subprocess.CalledProcessError as e:
        print(f"An error occurred while running the game: {e}")
    except FileNotFoundError:
        print(f"Error: Could not find the game executable at '{exe_path}'")

if __name__ == "__main__":
    launch_game()