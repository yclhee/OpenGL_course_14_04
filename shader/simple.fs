#version 330 core

uniform vec4 color;
out vec4 fragColor;

void main() {
    // fragColor = vec4(1.0, 0.0, 0.0, 1.0); //
    //fragColor = vec4(1.0, 1.0, 0.0, 1.0);
    fragColor = color;
}